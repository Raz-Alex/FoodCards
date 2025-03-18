namespace FoodCards.Shared.Dish
{
    public interface INutrition
    {
        decimal Kalories { get; set; }
        decimal Protein { get; set; }
        decimal Fat { get; set; }
        decimal SaturatedFat { get; set; }
        decimal Carbohydrate { get; set; }
        decimal Sugar { get; set; }
        decimal Salt { get; set; }
        decimal Fiber { get; set; }
        public int BaseQuantity { get; set; }
    }
}
