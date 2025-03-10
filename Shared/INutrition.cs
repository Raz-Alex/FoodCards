namespace FoodCards.Shared
{
    public interface INutrition
    {
        int Id { get; set; }
        string Name { get; set; }
        string Photo { get; set; }
        IngredientType Type { get;}
        int Kalories { get;}
        decimal Protein { get;}
        decimal Fat { get;}
        decimal SaturatedFat { get;}
        decimal Carbohydrate { get;}
        decimal Sugar { get;}
        decimal Salt { get; }
        decimal Fiber { get; }
        int DefaultGramms { get; set; }
    }
}
