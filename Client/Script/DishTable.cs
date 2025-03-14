using FoodCards.Shared.Dish;
using FoodCards.Shared.Quantity;

namespace FoodCards.Client.Script
{
    public class DishTable
    {
        public List<FoodItem> Ingredients { get; } = new()
        {
            new ()
            {
                Id = 0,
                Name = "Chicken Brest",
                Photo = "chickenBreast.jpg",
                Type = IngredientType.MeatAndFish,
                Kalories = 102,
                Quantity = new Grams()
            },
            new ()
            {
                Id = 1,
                Name = "Egg",
                Photo = "eggs.png",
                Type = IngredientType.EggsAndDairy,
                Kalories = 92,
                Quantity = new Grams()
            },
            new ()
            {
                Id = 2,
                Name = "Milk",
                Photo = "milk.jpg",
                Type = IngredientType.EggsAndDairy,
                Kalories = 64,
                Quantity = new Grams()
            },
            new ()
            {
                Id = 3,
                Name = "Paprika",
                Photo = "paprika.jpg",
                Type = IngredientType.Vegetables,
                Kalories = 20,
                Quantity = new Grams()
            },
            new ()
            {
                Id = 4,
                Name = "Apple",
                Photo = "apple.jpg",
                Type = IngredientType.Fruits,
                Kalories = 52,
                Quantity = new Grams()
            },
            new ()
            {
                Id = 5,
                Name = "Bread",
                Photo = "bread.jpg",
                Type = IngredientType.GrainsAndPotatoes,
                Kalories = 259,
                Quantity = new Grams()
            },
            new ()
            {
                Id = 6,
                Name = "Mandeln",
                Photo = "mandeln.jpg",
                Type = IngredientType.Fats,
                Kalories = 569,
                Quantity = new Grams()
            }
        };
    }
}
