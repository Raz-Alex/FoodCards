namespace FoodCards.Shared
{
    public class MealIngredient
    {
        public Guid MealId { get; set; }
        public Guid IngredientId { get; set; }
        public int Quantity { get; set; }
    }
}
