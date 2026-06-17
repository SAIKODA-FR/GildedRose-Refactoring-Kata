using System;

namespace GildedRoseKata;

public class Item
{
    private const int MAX_QUALITY = 50;
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void DecreaseSellin()
    {
        SellIn = SellIn - 1;
    }

    public void IncreaseQuality()
    {
        if (Quality < MAX_QUALITY)
        {
            Quality = Quality + 1;
        }
    }

    public void IncreaseQuality(int qualityIncrease)
    {
        if (Quality < MAX_QUALITY)
        {
            Quality = Math.Min(MAX_QUALITY, Quality + qualityIncrease);
        }
    }

    public void DecreaseQuality()
    {
        Quality = Quality - 1;
    }
}