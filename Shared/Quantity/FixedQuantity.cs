namespace FoodCards.Shared.Quantity
{
    public class FixedQuantity : IQuantity
    {
        public string MesurmentUnit => "unit";
        public int BaseQuantity => 1;
        public int Quantity { get; set; }

        public FixedQuantity(int quantity = 1)
        {
            Quantity = quantity;
        }
    }
}
