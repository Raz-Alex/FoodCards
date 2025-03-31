using FoodCards.Shared.Dish;

namespace FoodCards.Client.Script
{
    public interface IDictionary
    {
        string Accept { get; }
        string AddFoodItem { get; }
        string AddMoreMeals { get; }
        string Breakfast { get; }
        string CalculateFor { get; }
        string CalorieCount { get; }
        string Cancel { get; }
        string Carbs { get; }
        string CreateMeal { get; }
        string DailyKalorieTarget { get; }
        string Databank { get; }
        string Dinner { get; }
        string Fat { get; }
        string Fiber { get; }
        string FoodType { get; }
        string Goals { get; }
        string Grams { get; }
        string Home { get; }
        string Calories { get; }
        string Lunch { get; }
        string Milliliters { get; }
        string Name { get; }
        string Protein { get; }
        string Salt { get; }
        string SatFat { get; }
        string SelectItem { get; }
        string Snack { get; }
        string Sugar { get; }
        string Unit { get; }
        string UploadImage { get; }

        string FoodTypeName(IngredientType type);
        string FoodTypeShortCut(IngredientType type);
    }
}
