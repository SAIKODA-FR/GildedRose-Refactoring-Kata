namespace GildedRoseKata;

public class Item
{
    private const string AgedBrie = "Aged Brie";
    private const string BackStage = "Backstage passes to a TAFKAL80ETC concert";
    private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
    private const int MaxQuality = 50;

    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void ResetQuality()
    {
        Quality = 0;
    }

    public void DecreaseQuality()
    {
        if (Quality > 0)
        {
            Quality = Quality - 1;
        }
    }

    public void DecreaseSellin()
    {
        SellIn = SellIn - 1;
    }

    public void IncreaseQuality()
    {
        Quality = Quality + 1;
    }

    public void UpdateQuality()
    {
        if (Name == Sulfuras)
        {
            return;
        }
        if (Name == AgedBrie)
        {
            UpdateQualityAndSellinBrie();
            return;
        }
        if (Name == BackStage)
        {
            UpdateQualityAndSellinBackStage();
            return;
        }
        UpdateQualityAndSellin();
    }

    private void UpdateQualityAndSellinSulfuras()
    {

    }

    private void UpdateQualityAndSellin()
    {
        DecreaseQuality();

        DecreaseSellin();

        if (SellIn < 0)
        {
            DecreaseQuality();
        }
    }

    private void UpdateQualityAndSellinBackStage()
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

    private void UpdateQualityAndSellinBrie()
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