namespace FoodCards.Shared.Dish
{
    public interface IDish
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Photo { get; set; }
        IngredientType Type { get; }
        public string MesurmentUnit { get; set; }
        public int Quantity { get; set; }
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
