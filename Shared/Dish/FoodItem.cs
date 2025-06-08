using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodCards.Shared.Dish
{
    public class FoodItem : IItemTag, INutrition
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("photo")]
        public string Photo { get; set; }

        [Column("kalories")]
        public decimal Kalories { get; set; }

        [Column("fullkalories"), ReadOnly(true)]
        public virtual decimal FullKalories => Kalories * Coeficient;

        [Column("type"), Enum]
        public IngredientType Type { get; set; }

        [Column("mesurmentunit")]
        public string MesurmentUnit { get; set; } = "g";

        [Column("quantity")]
        public int Quantity { get; set; } = 100;

        [Column("basequantity")]
        public int BaseQuantity { get; set; } = 100;

        [Column("coeficient"), ReadOnly(true)]
        public decimal Coeficient => (decimal)Quantity / BaseQuantity;

        [Column("protein")]
        public decimal Protein { get; set; }

        [Column("fat")]
        public decimal Fat { get; set; }

        [Column("saturatedfat")]
        public decimal SaturatedFat { get; set; }

        [Column("carbohydrate")]
        public decimal Carbohydrate { get; set; }

        [Column("sugar")]
        public decimal Sugar { get; set; }

        [Column("salt")]
        public decimal Salt { get; set; }

        [Column("fiber")]
        public decimal Fiber { get; set; }

        public FoodItem Clone() => new()
            {
                Id = Id,
                Name = Name,
                Photo = Photo,
                Kalories = Kalories,
                Type = Type,
                MesurmentUnit = MesurmentUnit,
                Quantity = Quantity,
                BaseQuantity = BaseQuantity,
                Protein = Protein,
                Fat = Fat,
                SaturatedFat = SaturatedFat,
                Carbohydrate = Carbohydrate,
                Sugar = Sugar,
                Salt = Salt,
                Fiber = Fiber
            };
    }
}
