using FoodCards.Shared.Quantity;

namespace FoodCards.Shared.Dish
{
    public interface IDish
    {
        int Id { get; set; }
        string Name { get; set; }
        string Photo { get; set; }
        IngredientType Type { get; }
        IQuantity Quantity { get; }
    }

    public enum IngredientType
    {
        MeatAndFish,
        EggsAndDairy,
        GrainsAndPotatoes,
        Vegetables,
        Fruits,
        Fats,
        SweetsAndAlcohol,
        Processed,
        HomeMadeMeal,
        None
    }

    public enum IngredientType2
    {
        Meat,
        Poultry,
        Fish,
        Seafood,
        Eggs,
        Dairy,
        Grains,
        Potatoes,
        Vegies,
        Fruits,
        Nuts,
        Herbs,
        OilsAndFats,
        Sweets,
        Processed
    }
}
