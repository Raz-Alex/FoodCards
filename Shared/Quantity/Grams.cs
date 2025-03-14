﻿namespace FoodCards.Shared.Quantity
{
    public class Grams : IQuantity
    {
        public string MesurmentUnit => "g";
        public int BaseQuantity { get;}
        public int Quantity { get; set; }

        public Grams(int baseQuantity = 100, int quantity = 100)
        {
            Quantity = quantity;
            BaseQuantity = baseQuantity;
        }
    }
}
