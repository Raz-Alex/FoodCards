using FoodCards.Shared;

namespace FoodCards.Client.Script
{
    public class Const
    {
        public static IngredientData Get(IngredientType type) => type switch
        {
            IngredientType.EggsAndDairy =>
                new("Eggs & Dairy", "hsl(0, 0%, 90%)",
                    "radial-gradient(25rem 150% at top left, hsl(210, 0%, 99%), hsl(210, 0%, 97%))",
                    "1px solid hsl(0, 0%, 87%)"),
            IngredientType.MeatAndFish =>
                new("Meat & Fish", "hsl(0, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(0, 75%, 99%), hsl(0, 75%, 97%))",
                    "1px solid hsl(0, 75%, 87%)"),
            IngredientType.GrainsAndPotatoes =>
                new("Grains & Potatoes", "hsl(60, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(60, 75%, 99%), hsl(60, 75%, 97%))",
                    "1px solid hsl(60, 75%, 87%)"),
            IngredientType.Vegetables =>
                new("Vegetables", "hsl(120, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(120, 75%, 99%), hsl(120, 75%, 97%))",
                    "1px solid hsl(120, 75%, 87%)"),
            IngredientType.Fruits =>
                new("Fruits", "hsl(180, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(180, 75%, 99%), hsl(180, 75%, 97%))",
                    "1px solid hsl(180, 75%, 87%)"),
            IngredientType.Fats =>
                new("Fats", "hsl(240, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(240, 75%, 99%), hsl(240, 75%, 97%))",
                    "1px solid hsl(240, 75%, 87%)"),
            IngredientType.SweetsAndAlcohol =>
                new("Sweets & Alcohol", "hsl(300, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(300, 75%, 99%), hsl(300, 75%, 97%))",
                    "1px solid hsl(300, 75%, 87%)"),
            IngredientType.Processed =>
                new("Processed", "hsl(0, 0%, 10%)",
                    "radial-gradient(25rem 150% at top left, hsl(210, 0%, 29%), hsl(210, 0%, 27%))",
                    "1px solid hsl(0, 0%, 37%)"),
            IngredientType.HomeMadeMeal =>
                new("Meal", "hsl(210, 0%, 75%, 50%)",
                    "radial-gradient(25rem 150% at top left, hsl(210, 75%, 99%), hsl(210, 75%, 97%))",
                    "1px solid hsl(210, 75%, 87%)"),
            IngredientType.None => new("","","",""),
            _ => throw new NotImplementedException(),
        };

        public static string GetShortcut(IngredientType type) => type switch
		{
			IngredientType.EggsAndDairy => "E&D",
			IngredientType.MeatAndFish => "M&F",
			IngredientType.GrainsAndPotatoes => "G&P",
			IngredientType.Vegetables => "Veg",
			IngredientType.Fruits => "Frt",
			IngredientType.Fats => "Fat",
			IngredientType.SweetsAndAlcohol => "S&A",
			IngredientType.Processed => "Pro",
			IngredientType.HomeMadeMeal => "Meal",
			_ => ""
		};
}

    public class IngredientData
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Gradient { get; set; }
        public string Border { get; set; }

        public IngredientData(string name, string color, string gradient, string border)
        {
            Name = name;
            Color = color;
            Gradient = gradient;
            Border = border;
        }
    }
}
