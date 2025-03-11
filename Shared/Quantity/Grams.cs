namespace FoodCards.Shared.Quantity
{
    public class Grams : IQuantity
    {
        public int BaseQuantity { get; }
        public int Quantity { get; set; }

        public Grams(int quantity = 100, int baseQuantity = 100)
        {
            Quantity = quantity;
            BaseQuantity = baseQuantity;
        }
    }
}
