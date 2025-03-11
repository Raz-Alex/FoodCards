namespace FoodCards.Client.Layouts
{
    public class ChartBar
    {
        public string Name { get; set; }
        public decimal Percent { get; set; }
        public string Text { get; set; }
        public int CalculatePer => Percent < 1 ? (int)(Percent * 100) : 100;
        public int ColorPer => Percent <= 1 ? 50 + (100 - CalculatePer) / 2 :
                               Percent < 1.5m ? 50 - (int)((Percent - 1) * 50) : 0; 

        public ChartBar(string name, decimal percent, string text)
        {
            Name = name;
            Percent = percent;
            Text = text;
        }
    }
}
