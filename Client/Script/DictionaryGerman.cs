using FoodCards.Shared.Dish;

namespace FoodCards.Client.Script
{
    public class DictionaryGerman : IDictionary
    {
        public string Accept => "Akzeptieren";

        public string AddFoodItem => "Neue Zutate hinzufügen";

        public string AddMoreMeals => "Weitere Mahlzeiten hinzufügen";

        public string Breakfast => "Frühstück";

        public string CalculateFor => "Berechnen für";

        public string CalorieCount => "Zählen Sie Ihre Kalorien!";

        public string Cancel => "Abrechen";

        public string Carbs => "Kohlenhydrate";

        public string CreateMeal => "Meal erstellen";

        public string DailyKalorieTarget => "Tages Kalorien Ziele";

        public string Databank => "Database";

        public string Dinner => "Abendbrot";

        public string Fat => "Fett";

        public string Fiber => "Ballaststoffe";

        public string FoodType => "Lebensmittelart";

        public string Goals => "Ziele";

        public string Grams => "Gramm";

        public string Home => "Home";

        public string Calories => "Kalorien";

        public string Lunch => "Mittags";

        public string Milliliters => "Milliliter";

        public string Name => "Name";

        public string Protein => "Eiweiße";

        public string Salt => "Salz";

        public string SatFat => "Gesättigte Fettsäuren";

        public string SelectItem => "Stellen Sie Ihre Mahlzeit zusammen, indem Sie die Zutaten aus der folgenden Liste auswählen!";

        public string Snack => "Snack";

        public string Sugar => "Zucker";

        public string Unit => "Stück";

        public string UploadImage => "Bild hochladen";

        public string FoodTypeName(IngredientType type) => type switch
        {
            IngredientType.EggsAndDairy => "Eier und Milchprodukte",
            IngredientType.MeatAndFish => "Fleisch und Fisch",
            IngredientType.GrainsAndPotatoes => "Getreide und Kartoffeln",
            IngredientType.Vegetables => "Gemüse",
            IngredientType.Fruits => "Obst",
            IngredientType.Fats => "Fette",
            IngredientType.SweetsAndAlcohol => "Süßigkeiten und Alkohol",
            IngredientType.Processed => "Verarbeitet",
            IngredientType.HomeMadeMeal => "Mahlzeit",
            _ => ""
        };

        public string FoodTypeShortCut(IngredientType type) => type switch
        {
            IngredientType.EggsAndDairy => "E&D",
            IngredientType.MeatAndFish => "M&F",
            IngredientType.GrainsAndPotatoes => "G&K",
            IngredientType.Vegetables => "Gem",
            IngredientType.Fruits => "Obst",
            IngredientType.Fats => "Fet",
            IngredientType.SweetsAndAlcohol => "S&A",
            IngredientType.Processed => "Ver",
            IngredientType.HomeMadeMeal => "Mehl",
            _ => ""
        };
    }
}
