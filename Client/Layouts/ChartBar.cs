namespace FoodCards.Client.Layouts
{
    public class ChartBar
    {
        public string Name { get; set; }
        public decimal Percent { get; set; }
        public string Text { get; set; }

        public ChartBar(string name, decimal percent, string text)
        {
            Name = name;
            Percent = percent;
            Text = text;
        }
    }
}
