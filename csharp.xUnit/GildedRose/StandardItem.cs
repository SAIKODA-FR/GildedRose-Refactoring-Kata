namespace GildedRoseKata
{
    internal class StandardItem(string name, int sellIn, int quality) : Item(name, sellIn, quality)
    {
        public override void UpdateQuality()
        {
            DecreaseQuality();

            DecreaseSellIn();

            if (SellIn < 0)
            {
                DecreaseQuality();
            }
        }
    }
}