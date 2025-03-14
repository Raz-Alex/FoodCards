﻿using FoodCards.Shared.Quantity;

namespace FoodCards.Shared.Dish
{
    public class FoodItem : IDish, INutrition
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Photo { get; set; }

        public decimal Kalories { get; set; }

        public virtual decimal FullKalories => Kalories * Coeficient;

        public IngredientType Type { get; set; }

        public IQuantity Quantity { get; set; } = new Grams();

        public decimal Coeficient => (decimal)Quantity.Quantity / Quantity.BaseQuantity;

        public decimal Protein { get; set; }

        public decimal Fat { get; set; }

        public decimal SaturatedFat { get; set; }

        public decimal Carbohydrate { get; set; }

        public decimal Sugar { get; set; }

        public decimal Salt { get; set; }

        public decimal Fiber { get; set; }
    }
}
