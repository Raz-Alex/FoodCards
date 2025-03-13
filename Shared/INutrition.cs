namespace FoodCards.Shared
{
    public interface INutrition
    {
        int Id { get; set; }
        string Name { get; set; }
        string Photo { get; set; }
        IngredientType Type { get; set; }
        int Kalories { get; set; }
        decimal Protein { get; set; }
        decimal Fat { get; set; }
        decimal SaturatedFat { get; set; }
        decimal Carbohydrate { get; set; }
        decimal Sugar { get; set; }
        decimal Salt { get; set; }
        decimal Fiber { get; set; }
    }
}
