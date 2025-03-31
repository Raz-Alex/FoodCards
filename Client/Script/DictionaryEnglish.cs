using FoodCards.Shared.Dish;

namespace FoodCards.Client.Script
{
    public class DictionaryEnglish : IDictionary
    {
        public string Accept => "Accept";

        public string CalorieCount => "Count your calories!";

        public string AddFoodItem => "Add new ingredient";

        public string AddMoreMeals => "Add new meal";

        public string Breakfast => "Breakfast";

        public string CalculateFor => "Calculate for";

        public string Cancel => "Cancel";

        public string CreateMeal => "Create meal";

        public string DailyKalorieTarget => "Daily calorie target";

        public string Databank => "Databank";

        public string Dinner => "Dinner";

        public string FoodType => "Food kategory";

        public string Goals => "Goals";

        public string Grams => "Grams";

        public string Home => "Home";

        public string Calories => "Calories";

        public string Lunch => "Lunch";

        public string Milliliters => "Milliliters";

        public string Name => "Name";

        public string Snack => "Snack";

        public string SelectItem => "Please build your meal by selecting the ingredients from the list below!";

        public string Unit => "Unit";

        public string UploadImage => "UploadImage";

        public string Carbs => "Carbs";

        public string Fat => "Fat";

        public string Fiber => "Fiber";

        public string Protein => "Protein";

        public string Salt => "Salt";

        public string SatFat => "SatFat";

        public string Sugar => "Sugar";

        public string FoodTypeName(IngredientType type) => type switch
        {
            IngredientType.EggsAndDairy => "Eggs & Dairy",
            IngredientType.MeatAndFish => "Meat & Fish",
            IngredientType.GrainsAndPotatoes => "Grains & Potatoes",
            IngredientType.Vegetables => "Vegetables",
            IngredientType.Fruits => "Fruits",
            IngredientType.Fats => "Fats",
            IngredientType.SweetsAndAlcohol => "Sweets & Alcohol",
            IngredientType.Processed => "Processed",
            IngredientType.HomeMadeMeal => "Meal",
            _ => ""
        };

        public string FoodTypeShortCut(IngredientType type) => type switch
        {
            IngredientType.EggsAndDairy => "E&D",
            IngredientType.MeatAndFish => "M&F",
            IngredientType.GrainsAndPotatoes => "G&P",
            IngredientType.Vegetables => "Veg",
            IngredientType.Fruits => "Frt",
            IngredientType.Fats => "Fat",
            IngredientType.SweetsAndAlcohol => "S&A",
            IngredientType.Processed => "Pro",
            IngredientType.HomeMadeMeal => "Meal",
            _ => ""
        };
    }
}
