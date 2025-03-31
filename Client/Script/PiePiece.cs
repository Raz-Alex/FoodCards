namespace FoodCards.Client.Script
{
    public class PiePiece
    {
        public string Text { get; set; }
        public decimal Items { get; set; }
        public decimal Percentage { get; set; }
        public int Degrece => (int)(Percentage * 360);
        public string Color { get; set; }

        public PiePiece(string text, decimal items, decimal percentage, string color)
        {
            Text = text;
            Items = items;
            Percentage = percentage;
            Color = color;
        }

     //  public PiePiece(IngredientData data, string text, decimal items, decimal percentage)
     //  {
     //      Text = text;
     //      Items = items;
     //      Percentage = percentage;
     //      Color = data.Color;
     //  }

        public PiePiece()
        {
            Text = string.Empty;
        }

        //public PiePiece(DataSet dataSet)
        //{
        //    Text = dataSet.Name;
        //    Color = dataSet.Color;
        //    Percentage = 1;
        //    _ = int.TryParse(dataSet.Items, out int items);
        //    Items = items;
        //}
        //
        //public PiePiece(DataSet dataSet, int maxItems)
        //{
        //    Text = dataSet.Name;
        //    Color = dataSet.Color;
        //
        //    _ = int.TryParse(dataSet.Items, out int items);
        //    Items = items;
        //    Percentage = (decimal)items / maxItems;
        //}
    }
}
