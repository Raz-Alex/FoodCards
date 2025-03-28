using System.Text.Json;

namespace FoodCards.Server.Services
{
    //DataService -> IDataReaderService
    public class DataService
    {
        public async Task<List<T>> LoadAsync<T>(string table)
        {
            var path = $"{Path(table)}.json";
            if (!File.Exists(path))
                return [];

            using var reader = new StreamReader(path);
            var json = await reader.ReadToEndAsync();
            if (string.IsNullOrEmpty(json))
                return [];

            try
            {
                var obj = JsonSerializer.Deserialize<List<T>>(json);
                return obj ?? [];
            }
            catch(Exception ex)
            {
                return null;
            }
        }

      //  public async Task<DataSet> LoadSingleByIdAsync(string table, string id)
      //  {
      //      var path = $"{Path(table)}.x";
      //      if (!File.Exists(path))
      //          return default;
      //
      //      using var reader = new StreamReader(path);
      //      var json = await reader.ReadToEndAsync();
      //      var obj = JsonSerializer.Deserialize(json, typeof(List<DataSet>));
      //      if(obj == null || obj is not List<DataSet> list || list.Count == 0)
      //          return default;
      //
      //      var result = list.Where(x => x.Id == id).FirstOrDefault();
      //      
      //      return result;
      //  }
      //
      //  public async Task<PieViewDetails> LoadViewByIdAsync(string table, string id)
      //  {
      //      var path = $"{Path(table)}.x";
      //      if (!File.Exists(path))
      //          return default;
      //
      //      using var reader = new StreamReader(path);
      //      var json = await reader.ReadToEndAsync();
      //      var obj = JsonSerializer.Deserialize(json, typeof(List<PieViewDetails>));
      //      if (obj == null || obj is not List<PieViewDetails> list || list.Count == 0)
      //          return default;
      //
      //      var result = list.Where(x => x.Id == id).FirstOrDefault();
      //
      //      return result;
      //  }
      //
      //  public async Task<BarChartViewDetails> LoadBarChartViewByIdAsync(string table, string id)
      //  {
      //      var path = $"{Path(table)}.x";
      //      if (!File.Exists(path))
      //          return default;
      //
      //      using var reader = new StreamReader(path);
      //      var json = await reader.ReadToEndAsync();
      //      var obj = JsonSerializer.Deserialize(json, typeof(List<BarChartViewDetails>));
      //      if (obj == null || obj is not List<BarChartViewDetails> list || list.Count == 0)
      //          return default;
      //
      //      var result = list.Where(x => x.Id == id).FirstOrDefault();
      //
      //      return result;
      //  }

        public async Task SaveJsonDirect(string jsonString, string table)
        {
            var path = $"{Path(table)}.json";

            if (!File.Exists(path))
                File.Create(path);

            using var writer = new StreamWriter(path);
            await writer.WriteAsync(jsonString);
        }

        public async Task SaveAsync<T>(List<T> values, string table)
        {
            var jsonString = JsonSerializer.Serialize<object>(values);
            var path = $"{Path(table)}.json";

            if (!File.Exists(path))
                File.Create(path);

            using var writer = new StreamWriter(path);
            await writer.WriteAsync(jsonString);
        }

        public async Task InsertAsync<T>(T value, string table)
        {
            var data = await LoadAsync<T>(table);
            data.Add(value);
            await SaveAsync(data, table);
        }

        public async Task InsertListAsync<T>(List<T> values, string table)
        {
            var data = await LoadAsync<T>(table);
            data.AddRange(values);
            await SaveAsync(data, table);
        }

        static string Path(string file) => $"{Directory.GetCurrentDirectory()}/{file}";
    }
}
