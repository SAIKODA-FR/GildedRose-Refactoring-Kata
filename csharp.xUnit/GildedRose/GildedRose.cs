using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private const string AgedBrie = "Aged Brie";
    private const string BackStage = "Backstage passes to a TAFKAL80ETC concert";
    private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
    private const int MAX_QUALITY = 50;
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (Item item in Items)
        {
            if (item.Name == Sulfuras)
            {
                UpdateSulfurasQuality(item);
                continue;
            }
            if (item.Name == BackStage)
            {
                UpdateBackStageQuality(item);
                continue;
            }
            if (item.Name == AgedBrie)
            {
                UpdateBrieQuality(item);
                continue;
            }
            UpdateItemQuality(item);
        }
    }

    private static void UpdateBackStageQuality(Item item)
    {
        
        IncreaseQuality(item);
        
        if (item.SellIn <= 10)
        {
            IncreaseQuality(item);
        }

        if (item.SellIn <= 5)
        {
           IncreaseQuality(item);
        }

        DecreaseSellin(item);

        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }

    private static void UpdateBrieQuality(Item item)
    {
        IncreaseQuality(item);

        DecreaseSellin(item);

        if (item.SellIn < 0)
        {
           IncreaseQuality(item);
        }
    }

    private static void UpdateItemQuality(Item item)
    {

        if (item.Quality > 0)
        {
            DecreaseQuality(item);
        }

        DecreaseSellin(item);

        if (item.SellIn < 0)
        {
            if (item.Quality > 0)
            {
                DecreaseQuality(item);
            }
        }
    }


    private static void UpdateSulfurasQuality(Item item)
    {
    }

    private static void DecreaseSellin(Item item)
    {
        item.SellIn = item.SellIn - 1;
    }

    private static void IncreaseQuality(Item item)
    {
        if (item.Quality < MAX_QUALITY)
        {
            item.Quality = item.Quality + 1;
        }
    }

    private static void DecreaseQuality(Item item)
    {
        item.Quality = item.Quality - 1;
    }
}