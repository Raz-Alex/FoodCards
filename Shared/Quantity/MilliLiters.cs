namespace FoodCards.Shared.Quantity
{
    public class MilliLiters : IQuantity
    {
        public string MesurmentUnit => "ml";
        public int BaseQuantity { get;}
        public int Quantity { get; set; }

        public MilliLiters(int baseQuantity = 100, int quantity = 100)
        {
            Quantity = quantity;
            BaseQuantity = baseQuantity;
        }
    }
}
