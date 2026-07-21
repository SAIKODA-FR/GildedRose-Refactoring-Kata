namespace GildedRoseKata
{
    internal class StandardItem : Item
    {
        public override void UpdateQuality()
        {
            if (Quality > MIN_QUALITY)
            {
                DecreaseQuality();
            }

            DecreaseSellIn();

            if (SellIn < 0)
            {
                if (Quality > MIN_QUALITY)
                {
                    DecreaseQuality();
                }
            }
        }
    }
}