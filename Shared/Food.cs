namespace FoodCards.Shared
{
    public class Food : INutrition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public int Kalories => Ingredients.Sum(x => x.Kalories) * (int)QuantityCoeficient ;
        public decimal Protein => Ingredients.Sum(x => x.Protein) * QuantityCoeficient;
        public decimal Fat => Ingredients.Sum(x => x.Fat) * QuantityCoeficient;
        public decimal SaturatedFat => Ingredients.Sum(x => x.SaturatedFat) * QuantityCoeficient;
        public decimal Carbohydrate => Ingredients.Sum(x => x.Carbohydrate) * QuantityCoeficient;
        public decimal Sugar => Ingredients.Sum(x => x.Sugar) * QuantityCoeficient;
        public decimal Salt => Ingredients.Sum(x => x.Salt) * QuantityCoeficient;
        public decimal Fiber => Ingredients.Sum(x => x.Fiber) * QuantityCoeficient;
        public List<Ingredient> Ingredients { get; set; } = new();
        public IngredientType Type { get; }
        public int Portions { get; set; } = 1;
        public int DefaultGramms { get; set; } = 100;
        public int Gramms { get; set; } = 100;
        decimal QuantityCoeficient => (decimal)Gramms / DefaultGramms / Portions;
    }
}
