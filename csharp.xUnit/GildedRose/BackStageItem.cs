namespace GildedRoseKata;

public class BackStageItem(string name, int sellIn, int quality) : BaseItem(name,sellIn,quality)
{
    private void ResetQuality()
    {
        Quality = 0;
    }

    public override void UpdateQuality()
    {
        if (Quality < MaxQuality)
        {
            IncreaseQuality();

            if (SellIn < 11)
            {
                if (Quality < MaxQuality)
                {
                    IncreaseQuality();
                }
            }

            if (SellIn < 6)
            {
                if (Quality < MaxQuality)
                {
                    IncreaseQuality();
                }
            }
        }

        DecreaseSellin();

        if (SellIn < 0)
        {
            ResetQuality();
        }
    }
}