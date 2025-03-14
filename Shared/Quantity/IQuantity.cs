namespace FoodCards.Shared.Quantity
{
    public interface IQuantity
    {
        string MesurmentUnit { get; }
        int BaseQuantity { get;}
        int Quantity { get; set; }
    }
}
