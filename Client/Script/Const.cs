using FoodCards.Shared;

namespace FoodCards.Client.Script
{
    public class Const
    {
        public static IngredientData Get(IngredientType type) => type switch
        {
            IngredientType.EggsAndDairy =>
                new("Eggs & Dairy", "hsl(0, 0%, 90%)",
                    "radial-gradient(25rem 150% at top left, hsl(210, 0%, 99%), hsl(210, 0%, 97%))"),
            IngredientType.MeatAndFish =>
                new("Meat & Fish", "hsl(0, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(0, 75%, 99%), hsl(0, 75%, 97%))"),
            IngredientType.GrainsAndPotatoes =>
                new("Grains & Potatoes", "hsl(60, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(60, 75%, 99%), hsl(60, 75%, 97%))"),
            IngredientType.Vegetables =>
                new("Vegetables", "hsl(120, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(120, 75%, 99%), hsl(120, 75%, 97%))"),
            IngredientType.Fruits =>
                new("Fruits", "hsl(180, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(180, 75%, 99%), hsl(180, 75%, 97%))"),
            IngredientType.Fats =>
                new("Fats", "hsl(240, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(240, 75%, 99%), hsl(240, 75%, 97%))"),
            IngredientType.SweetsAndAlcohol =>
                new("Sweets & Alcohol", "hsl(300, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(300, 75%, 99%), hsl(300, 75%, 97%))"),
            IngredientType.Processed =>
                new("Processed", "hsl(0, 0%, 10%)",
                    "radial-gradient(25rem 150% at top left, hsl(210, 0%, 9%), hsl(210, 0%, 7%))"),
            IngredientType.HomeMadeMeal =>
                new("Meal", "hsl(210, 0%, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(210, 75%, 99%), hsl(210, 75%, 97%))"),
            _ => throw new NotImplementedException(),
        };
    }

    public class IngredientData
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Gradient { get; set; }

        public IngredientData(string name, string color, string gradient)
        {
            Name = name;
            Color = color;
            Gradient = gradient;
        }
    }
}
