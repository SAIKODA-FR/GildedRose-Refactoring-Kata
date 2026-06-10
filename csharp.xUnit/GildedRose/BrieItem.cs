namespace GildedRoseKata;

public class BrieItem(string name, int sellIn, int quality) : BaseItem(name, sellIn, quality)
{
    public override void UpdateQuality()
    {
        if (Quality < MaxQuality)
        {
            IncreaseQuality();
        }

        DecreaseSellin();

        if (SellIn < 0)
        {
            if (Quality < MaxQuality)
            {
                IncreaseQuality();
            }
        }
    }
}