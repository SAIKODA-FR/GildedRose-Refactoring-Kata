namespace GildedRoseKata
{
    internal class AgedBrieItem(string name, int sellIn, int quality) : Item(name, sellIn, quality)
    {
        public override void UpdateQuality()
        {

            IncreaseQuality();

            DecreaseSellIn();

            if (SellIn < 0)
            {
                IncreaseQuality();
            }
        }
    }
}
