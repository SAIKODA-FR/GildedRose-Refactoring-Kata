using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private const string AgedBrie = "Aged Brie";
    private const string BackStage = "Backstage passes to a TAFKAL80ETC concert";
    private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
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
        
        item.IncreaseQuality();
        
        if (item.SellIn <= 10)
        {
            item.IncreaseQuality();
        }

        if (item.SellIn <= 5)
        {
           item.IncreaseQuality();
        }

        item.DecreaseSellin();

        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }

    private static void UpdateBrieQuality(Item item)
    {
        item.DecreaseSellin();
        var qualityIncrease = item.SellIn < 0 ? 2 : 1;
        item.IncreaseQuality(qualityIncrease);
    }

    private static void UpdateItemQuality(Item item)
    {

        if (item.Quality > 0)
        {
            item.DecreaseQuality();
        }

        item.DecreaseSellin();

        if (item.SellIn < 0)
        {
            if (item.Quality > 0)
            {
                item.DecreaseQuality();
            }
        }
    }


    private static void UpdateSulfurasQuality(Item item)
    {
    }
}