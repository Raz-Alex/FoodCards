using FoodCards.Client.Script;
using FoodCards.Shared.Dish;

namespace FoodCards.Client.Services
{
    public class DictionaryService : IDictionary
    {
        IDictionary dictionary = new DictionaryGerman();

        public void ChangeLanguage(LanguageEnum language)
        {
            switch (language)
            {
                case LanguageEnum.English:
                    dictionary = new DictionaryEnglish();
                    break;

                case LanguageEnum.Deutsch:
                    dictionary = new DictionaryGerman();
                    break;
            }
        }

        public string Accept => dictionary.Accept;

        public string AddFoodItem => dictionary.AddFoodItem;

        public string AddMoreMeals => dictionary.AddMoreMeals;

        public string Breakfast => dictionary.Breakfast;

        public string CalculateFor => dictionary.CalculateFor;

        public string CalorieCount => dictionary.CalorieCount;

        public string Cancel => dictionary.Cancel;

        public string CreateMeal => dictionary.CreateMeal;

        public string DailyKalorieTarget => dictionary.DailyKalorieTarget;

        public string Databank => dictionary.Databank;

        public string Dinner => dictionary.Dinner;

        public string FoodType => dictionary.FoodType;

        public string Goals => dictionary.Goals;

        public string Grams => dictionary.Grams;

        public string Home => dictionary.Home;

        public string Calories => dictionary.Calories;

        public string Lunch => dictionary.Lunch;

        public string Milliliters => dictionary.Milliliters;

        public string Name => dictionary.Name;

        public string Snack => dictionary.Snack;

        public string SelectItem => dictionary.SelectItem;

        public string Unit => dictionary.Unit;

        public string UploadImage => dictionary.UploadImage;

        public string Carbs => dictionary.Carbs;

        public string Fat => dictionary.Fat;

        public string Fiber => dictionary.Fiber;

        public string Protein => dictionary.Protein;

        public string Salt => dictionary.Salt;

        public string SatFat => dictionary.SatFat;

        public string Sugar => dictionary.Sugar;

        public string FoodTypeName(IngredientType type) => dictionary.FoodTypeName(type);

        public string FoodTypeShortCut(IngredientType type) => dictionary.FoodTypeShortCut(type);
    }

    public enum LanguageEnum
    {
        English,
        Deutsch
    }
}
