namespace FoodCards.Shared
{
    public class Food : INutrition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public int Kalories => Ingredients.Sum(x => x.Kalories) * (int)quantityCoeficient ;
        public decimal Protein => Ingredients.Sum(x => x.Protein) * quantityCoeficient;
        public decimal Fat => Ingredients.Sum(x => x.Fat) * quantityCoeficient;
        public decimal SaturatedFat => Ingredients.Sum(x => x.SaturatedFat) * quantityCoeficient;
        public decimal Carbohydrate => Ingredients.Sum(x => x.Carbohydrate) * quantityCoeficient;
        public decimal Sugar => Ingredients.Sum(x => x.Sugar) * quantityCoeficient;
        public decimal Salt => Ingredients.Sum(x => x.Salt) * quantityCoeficient;
        public List<Ingredient> Ingredients { get; set; } = new();
        public IngredientType Type { get; }
        public int Portions { get; set; } = 1;
        public int DefaultGramms { get; set; } = 100;
        public int Gramms { get; set; } = 100;
        decimal quantityCoeficient => (decimal)Gramms / DefaultGramms / Portions;
    }
}
