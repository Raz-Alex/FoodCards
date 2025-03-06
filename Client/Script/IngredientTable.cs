using FoodCards.Shared;

namespace FoodCards.Client.Script
{
    public class IngredientTable
    {
        public List<Ingredient> Ingredients { get; } = new()
        {
            new()
            {
                Name = "Chicken Brest",
                Kalories = 102,
                Protein = 24,
                Carbohydrate = 0,
                Fat = 1,
                SaturatedFat = 0.32m
            },
            new()
            {
                Name = "Egg",
                Kalories = 92,
                Protein = 8,
                Carbohydrate = 0,
                Fat = 7,
                SaturatedFat = 2.52m
            },
            new()
            {
                Name = "Milk",
                Kalories = 64,
                Protein = 3,
                Carbohydrate = 5,
                Fat = 4,
                SaturatedFat = 3.84m
            },
            new()
            {
                Name = "Paprika",
                Kalories = 20,
                Protein = 1,
                Carbohydrate = 3,
                Fat = 0,
                SaturatedFat = 0
            },
            new()
            {
                Name = "Apple",
                Kalories = 52,
                Protein = 0,
                Carbohydrate = 11,
                Fat = 0,
                SaturatedFat = 0
            },
            new()
            {
                Name = "Bread",
                Kalories = 259,
                Protein = 8,
                Carbohydrate = 48,
                Fat = 3,
                SaturatedFat = 1.11m
            },
            new()
            {
                Name = "Mandeln",
                Kalories = 569,
                Protein = 19,
                Carbohydrate = 4,
                Fat = 54,
                SaturatedFat = 4.86m
            }
        };
    }
}
