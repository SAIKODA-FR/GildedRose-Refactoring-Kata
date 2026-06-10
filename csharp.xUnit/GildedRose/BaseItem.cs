namespace GildedRoseKata
{
    public abstract class BaseItem(string name, int sellIn, int quality) : IItem
    {
        protected const int MaxQuality = 50;
        public string Name { get; set; } = name;
        public int Quality { get; set; } = quality;
        public int SellIn { get; set; } = sellIn;

        protected void DecreaseQuality()
        {
            if (Quality > 0)
            {
                Quality--;
            }
        }


        protected void IncreaseQuality()
        {
            Quality++;
        }
        protected void DecreaseSellin()
        {
            SellIn--;
        }

        public abstract void UpdateQuality();

    }
}