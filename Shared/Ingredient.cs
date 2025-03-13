namespace FoodCards.Shared
{
    public class Ingredient: INutrition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public IngredientType Type { get; set; }
        public decimal Kalories { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal SaturatedFat { get; set; }
        public decimal Carbohydrate { get; set; }
        public decimal Sugar { get; set; }
        public decimal Salt { get; set; }
        public decimal Fiber { get; set; }


        /*
         * Name
         * Photo
         * protein*
         * kalories*
         * karbs*
         * sugar*
         * salt*
         * fat*
         * g fat*
         * other fats
         * fiber
         * others
         * vitamins
         * minerals
         * zutaten
         * purpose/health
         * acid/base
         * rating
         * sharf
         * alcohol
         */
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
