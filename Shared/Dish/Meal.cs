namespace FoodCards.Shared.Dish
{
    public class Meal : FoodItem
    {
        public List<FoodItem> Ingredients { get; set; } = new();

        public override decimal FullKalories => Ingredients.Sum(x => x.FullKalories);

        public Meal()
        {
            Type = IngredientType.HomeMadeMeal;
        }

        public void Calculate()
        {
            Kalories = Ingredients.Sum(x => x.FullKalories);
            Protein = Ingredients.Sum(x => x.Protein * x.Coeficient);
            Fat = Ingredients.Sum(x => x.Fat * x.Coeficient);
            SaturatedFat = Ingredients.Sum(x => x.SaturatedFat * x.Coeficient);
            Carbohydrate = Ingredients.Sum(x => x.Carbohydrate * x.Coeficient);
            Sugar = Ingredients.Sum(x => x.Sugar * x.Coeficient);
            Salt = Ingredients.Sum(x => x.Salt * x.Coeficient);
            Fiber = Ingredients.Sum(x => x.Fiber * x.Coeficient);
        }
    }
}
