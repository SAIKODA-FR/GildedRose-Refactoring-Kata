namespace GildedRoseKata;

public class Item(string name, int sellIn, int quality) : BaseItem(name,sellIn, quality)
{
    public override void UpdateQuality()
    {
        DecreaseQuality();

        DecreaseSellin();

        if (SellIn < 0)
        {
            DecreaseQuality();
        }
    }
}