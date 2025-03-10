using FoodCards.Shared;

namespace FoodCards.Client.Script
{
    public class IngredientTable
    {
        public List<Ingredient> Ingredients { get; } = new()
        {
            new()
            {
                Id = 0,
                Name = "Chicken Brest",
                Photo = "chickenBreast.jpg",
                Type = IngredientType.Protein,
                Kalories = 102,
                Protein = 24,
                Carbohydrate = 0,
                Fat = 1,
                SaturatedFat = 0.32m
            },
            new()
            {
                Id = 1,
                Name = "Egg",
                Photo = "eggs.png",
                Type = IngredientType.Fat,
                Kalories = 92,
                Protein = 8,
                Carbohydrate = 0,
                Fat = 7,
                SaturatedFat = 2.52m
            },
            new()
            {
                Id = 2,
                Name = "Milk",
                Photo = "milk.jpg",
                Type = IngredientType.Protein,
                Kalories = 64,
                Protein = 3,
                Carbohydrate = 5,
                Fat = 4,
                SaturatedFat = 3.84m
            },
            new()
            {
                Id = 3,
                Name = "Paprika",
                Photo = "paprika.jpg",
                Type = IngredientType.Vegie,
                Kalories = 20,
                Protein = 1,
                Carbohydrate = 3,
                Fat = 0,
                SaturatedFat = 0
            },
            new()
            {
                Id = 4,
                Name = "Apple",
                Photo = "apple.jpg",
                Type = IngredientType.Fruit,
                Kalories = 52,
                Protein = 0,
                Carbohydrate = 11,
                Fat = 0,
                SaturatedFat = 0
            },
            new()
            {
                Id = 5,
                Name = "Bread",
                Photo = "bread.jpg",
                Type = IngredientType.Carbs,
                Kalories = 259,
                Protein = 8,
                Carbohydrate = 48,
                Fat = 3,
                SaturatedFat = 1.11m
            },
            new()
            {
                Id = 6,
                Name = "Mandeln",
                Photo = "mandeln.jpg",
                Type = IngredientType.Fat,
                Kalories = 569,
                Protein = 19,
                Carbohydrate = 4,
                Fat = 54,
                SaturatedFat = 4.86m
            }
        };
    }
}
