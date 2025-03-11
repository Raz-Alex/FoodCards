using FoodCards.Shared.Quantity;

namespace FoodCards.Shared.Dish
{
    public interface IDish
    {
        int Id { get; set; }
        string Name { get; set; }
        string Photo { get; set; }
        int Kalories { get; }
        IngredientType Type { get; }
        IQuantity Quantity { get; }
    }
}
