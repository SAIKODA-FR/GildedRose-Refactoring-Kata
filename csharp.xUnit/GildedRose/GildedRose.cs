using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private const string AGED_BRIE = "Aged Brie";
    private const string BACKSTAGE = "Backstage passes to a TAFKAL80ETC concert";
    private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
    private const int MAX_QUALITY = 50;
    private const int MIN_QUALITY = 0;

    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (Item item in Items)
        {
            if (item.Name == SULFURAS)
            {
                continue;
            }
            if (item.Name == AGED_BRIE)
            {
                UpdateAgedBrieQuality(item);
            }
            else if (item.Name == BACKSTAGE)
            {
                UpdateBackstageQuality(item);
            }
            else
            {
                UpdateItemQuality(item);
            }
        }
    }

    private static void UpdateItemQuality(Item item)
    {
        if (item.Quality > MIN_QUALITY)
        {
            item.DecreaseQuality();
        }

        item.DecreaseSellIn();

        if (item.SellIn < 0)
        {
            if (item.Quality > MIN_QUALITY)
            {
                item.DecreaseQuality();

            }
        }
    }

    private static void UpdateBackstageQuality(Item item)
    {
        if (item.Quality < MAX_QUALITY)
        {
            item.IncreaseQuality();

            if (item.SellIn < 11)
            {
                if (item.Quality < MAX_QUALITY)
                {
                    item.IncreaseQuality();
                }
            }

            if (item.SellIn < 6)
            {
                if (item.Quality < MAX_QUALITY)
                {
                    item.IncreaseQuality();
                }
            }
        }

        item.DecreaseSellIn();

        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }

    private static void UpdateAgedBrieQuality(Item item)
    {
        if (item.Quality < MAX_QUALITY)
        {
            item.IncreaseQuality();
        }

        item.DecreaseSellIn();

        if (item.SellIn < 0)
        {
            if (item.Quality < MAX_QUALITY)
            {
                item.IncreaseQuality();
            }
        }
    }
}