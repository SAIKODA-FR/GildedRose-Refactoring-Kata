namespace GildedRoseKata
{
    internal class LegendaryItem(string name, int sellIn, int quality) : Item(name, sellIn, quality)
    {
        public override void UpdateQuality()
        {
        }
    }
}
