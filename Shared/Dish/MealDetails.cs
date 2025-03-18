namespace FoodCards.Shared.Dish
{
    public class MealDetails
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Photo { get; set; }

        public bool Breakfast { get; set; }

        public bool Lunch { get; set; }

        public bool Dinner { get; set; }

        public bool Snack { get; set; }
    }
}
