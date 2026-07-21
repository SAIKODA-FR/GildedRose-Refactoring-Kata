namespace GildedRoseKata
{
    internal class BackstageItem(string name, int sellIn, int quality) : Item(name, sellIn, quality)
    {
        public override void UpdateQuality()
        {

            IncreaseQuality();

            if (SellIn < 11)
            {
                IncreaseQuality();
            }

            if (SellIn < 6)
            {
                IncreaseQuality();
            }

            DecreaseSellIn();

            if (SellIn < 0)
            {
                SetMinimumQuality();
            }
        }
    }
}
