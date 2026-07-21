namespace GildedRoseKata
{
    internal class StandardItem : Item
    {
        public StandardItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

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