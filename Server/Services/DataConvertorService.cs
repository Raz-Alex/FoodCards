using FoodCards.Shared.Dish;
using MySqlConnector;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace FoodCards.Server.Services
{
    public class DataConvertorService
    {
        public List<T> Extract<T>(MySqlDataReader reader, ErrorService errorService)
        {
            var list = new List<T>();
            var properties = typeof(T).GetProperties();
            try
            {
                while (reader.Read())
                {
                    var obj = Activator.CreateInstance<T>();
                    list.Add(obj);
                    foreach (var property in properties)
                    {
                        var readOnly = property.GetCustomAttribute<ReadOnlyAttribute>();
                        if (readOnly != null && readOnly.IsReadOnly)
                            continue;

                        var column = property.GetCustomAttribute<ColumnAttribute>().Name;
                        if (property.PropertyType == typeof(int))
                            property.SetValue(obj, reader.GetInt32(column));
                        else if (property.PropertyType == typeof(string))
                            property.SetValue(obj, reader.GetString(column));
                        else if (property.PropertyType == typeof(decimal))
                            property.SetValue(obj, reader.GetDecimal(column));
                        else if (property.GetCustomAttribute<EnumAttribute>() != null)
                            property.SetValue(obj, reader.GetInt32(column));

                    }
                }
            }
            catch (Exception ex)
            {
                errorService.Error += " convert " + ex.Message + " ? " + ex.StackTrace;
            }

            return list;
        }
    }
}
