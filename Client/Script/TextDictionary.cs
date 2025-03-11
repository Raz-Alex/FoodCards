using FoodCards.Shared;

namespace FoodCards.Client.Script
{
    public class TextDictionary
    {
        public static string Get(IngredientType type) => type switch
        {
            IngredientType.EggsAndDairy => "",
            IngredientType.MeatAndFish => "",
            IngredientType.GrainsAndPotatoes => "",
            IngredientType.Vegetables => "",
            IngredientType.Fruits => "",
            IngredientType.Fats => "",
            IngredientType.Processed => "",
            IngredientType.HomeMadeMeal => "",
            _ => "",
        };
    }
}
