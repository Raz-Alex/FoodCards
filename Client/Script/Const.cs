using FoodCards.Shared.Dish;

namespace FoodCards.Client.Script
{
    public class Const
    {
        public static IngredientData Get(IngredientType type) => type switch
        {
            IngredientType.EggsAndDairy =>
                new( "hsl(0, 0%, 90%)",
                    "radial-gradient(25rem 150% at top left, hsl(210, 0%, 99%), hsl(210, 0%, 97%))",
                    "1px solid hsl(0, 0%, 87%)"),
            IngredientType.MeatAndFish =>
                new( "hsl(0, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(0, 75%, 99%), hsl(0, 75%, 97%))",
                    "1px solid hsl(0, 75%, 87%)"),
            IngredientType.GrainsAndPotatoes =>
                new( "hsl(60, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(60, 75%, 99%), hsl(60, 75%, 97%))",
                    "1px solid hsl(60, 75%, 87%)"),
            IngredientType.Vegetables =>
                new( "hsl(120, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(120, 75%, 99%), hsl(120, 75%, 97%))",
                    "1px solid hsl(120, 75%, 87%)"),
            IngredientType.Fruits =>
                new( "hsl(180, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(180, 75%, 99%), hsl(180, 75%, 97%))",
                    "1px solid hsl(180, 75%, 87%)"),
            IngredientType.Fats =>
                new( "hsl(240, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(240, 75%, 99%), hsl(240, 75%, 97%))",
                    "1px solid hsl(240, 75%, 87%)"),
            IngredientType.SweetsAndAlcohol =>
                new( "hsl(300, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(300, 75%, 99%), hsl(300, 75%, 97%))",
                    "1px solid hsl(300, 75%, 87%)"),
            IngredientType.Processed =>
                new( "hsl(0, 0%, 10%)",
                    "radial-gradient(25rem 150% at top left, hsl(210, 0%, 29%), hsl(210, 0%, 27%))",
                    "1px solid hsl(0, 0%, 37%)"),
            IngredientType.HomeMadeMeal =>
                new( "hsl(210, 0%, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(210, 75%, 99%), hsl(210, 75%, 97%))",
                    "1px solid hsl(210, 75%, 87%)"),
            IngredientType.None => new("","",""),
            _ => throw new NotImplementedException(),
        };
    }

    public class IngredientData(string color, string gradient, string border)
    {
        public string Color { get; set; } = color;
        public string Gradient { get; set; } = gradient;
        public string Border { get; set; } = border;
    }
}
