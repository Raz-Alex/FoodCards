using FoodCards.Shared;

namespace FoodCards.Client.Script
{
    public class FoodTable
    {
        public List<Food> Get()
        {
            var ingredients = new IngredientTable().Ingredients;
            return new List<Food>()
            {
                new ()
                {
                    Name = "Boiled Egg",
                    Ingredients = new (){ingredients[1]}
                },
                new ()
                {
                    Name = "Glass of Milk",
                    Ingredients = new (){ingredients[2]}
                },
                new ()
                {
                    Name = "Paprika & Chicken",
                    Ingredients = new (){ingredients[0], ingredients[3] }
                },
                new ()
                {
                    Name = "Salad",
                    Ingredients = new (){ingredients[1], ingredients[3], ingredients[4] }
                },
                new ()
                {
                    Name = "Fruit Salad",
                    Ingredients = new (){ingredients[4], ingredients[6] }
                },
                new ()
                {
                    Name = "Chicken Toast",
                    Ingredients = new (){ingredients[0], ingredients[5] }
                },
            };
        } 
    }
}
