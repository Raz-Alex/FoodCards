﻿using FoodCards.Shared.Dish;
using FoodCards.Shared.Quantity;

namespace FoodCards.Client.Script
{
    public class IngredientTable
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
                Protein = 24,
                Carbohydrate = 0,
                Fat = 1,
                SaturatedFat = 0
            },
            new()
            {
                Id = 10,
                Name = "Tomato",
                Photo ="tomato.jpg",
                Type = IngredientType.Vegetables,
                Kalories = 17,
                Protein = 1,
                Carbohydrate = 3,
                Fiber = 1
            },
            new ()
            {
                Id = 1,
                Name = "Egg",
                Photo = "eggs.png",
                Type = IngredientType.EggsAndDairy,
                Kalories = 92,
                Protein = 8,
                Carbohydrate = 0,
                Fat = 7,
                SaturatedFat = 3,
                Quantity = new FixedQuantity()
            },
            new ()
            {
                Id = 2,
                Name = "Milk",
                Photo = "milk.jpg",
                Type = IngredientType.EggsAndDairy,
                Kalories = 64,
                Protein = 3,
                Carbohydrate = 5,
                Fat = 4,
                SaturatedFat = 4,
                Quantity = new MilliLiters()
            },
            new ()
            {
                Id = 3,
                Name = "Paprika",
                Photo = "paprika.png",
                Type = IngredientType.Vegetables,
                Kalories = 20,
                Protein = 1,
                Carbohydrate = 3,
                Fat = 0,
                SaturatedFat = 0
            },
            new ()
            {
                Id = 4,
                Name = "Apple",
                Photo = "apple.jpg",
                Type = IngredientType.Fruits,
                Kalories = 52,
                Protein = 0,
                Carbohydrate = 11,
                Fat = 0,
                SaturatedFat = 0
            },
            new ()
            {
                Id = 5,
                Name = "Bread",
                Photo = "bread.jpg",
                Type = IngredientType.GrainsAndPotatoes,
                Kalories = 259,
                Protein = 8,
                Carbohydrate = 48,
                Fat = 3,
                SaturatedFat = 1
            },
            new ()
            {
                Id = 6,
                Name = "Mandeln",
                Photo = "mandeln.jpg",
                Type = IngredientType.Fats,
                Kalories = 569,
                Protein = 19,
                Carbohydrate = 4,
                Fat = 54,
                SaturatedFat = 5
            }
        };
    }
}
