namespace GildedRoseKata
{
    internal class ConjuredItem(string name, int sellIn, int quality) : Item(name, sellIn, quality)
    {
        public override void UpdateQuality()
        {
            DecreaseQuality();
            DecreaseQuality();

            DecreaseSellIn();

            if (SellIn < 0)
            {
                DecreaseQuality();
                DecreaseQuality();
            }
        }
    }
}
