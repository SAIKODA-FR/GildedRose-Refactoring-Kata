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
            UpdateItemQuality(item);
        }
    }

    private static void UpdateItemQuality(Item item)
    {
        if (item.Name != AgedBrie && item.Name != BackStage)
        {
            if (item.Quality > 0)
            {
                if (item.Name == Sulfuras)
                {
                }
                else
                {
                    DecreaseQuality(item);
                }
            }
        }
        else
        {
            if (item.Quality < MAX_QUALITY)
            {
                IncreaseQuality(item);

                if (item.Name == BackStage)
                {
                    if (item.SellIn <= 10)
                    {
                        if (item.Quality < MAX_QUALITY)
                        {
                            IncreaseQuality(item);
                        }
                    }

                    if (item.SellIn <= 5)
                    {
                        if (item.Quality < MAX_QUALITY)
                        {
                            IncreaseQuality(item);
                        }
                    }
                }
            }
        }

        if (item.Name == Sulfuras)
        {
        }
        else
        {
            DecreaseSellin(item);
        }

        if (item.SellIn < 0)
        {
            if (item.Name != AgedBrie)
            {
                if (item.Name != BackStage)
                {
                    if (item.Quality > 0)
                    {
                        if (item.Name == Sulfuras)
                        {
                        }
                        else {
                            DecreaseQuality(item);
                        }
                    }
                }
                else
                {
                    item.Quality = 0;
                }
            }
            else
            {
                if (item.Quality < MAX_QUALITY)
                {
                    IncreaseQuality(item);
                }
            }
        }
    }

    private static void DecreaseSellin(Item item)
    {
        item.SellIn = item.SellIn - 1;
    }

    private static void IncreaseQuality(Item item)
    {
        item.Quality = item.Quality + 1;
    }

    private static void DecreaseQuality(Item item)
    {
        item.Quality = item.Quality - 1;
    }
}