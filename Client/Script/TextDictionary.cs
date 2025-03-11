using FoodCards.Shared;

namespace FoodCards.Client.Script
{
    public class TextDictionary
    {
        public static string Get(IngredientType type) => type switch
        {
            IngredientType.EggsAndDairy => "Eggs & Dairy",
            IngredientType.MeatAndFish => "Meat & Fish",
            IngredientType.GrainsAndPotatoes => "Grains & Potatoes",
            IngredientType.Vegetables => "Vegetables",
            IngredientType.Fruits => "Fruits",
            IngredientType.Fats => "Fats",
            IngredientType.Processed => "Processed",
            IngredientType.HomeMadeMeal => "Meal",
            _ => "",
        };
    }
}
