using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private const string AGED_BRIE = "Aged Brie";
    private const string BACKSTAGE = "Backstage passes to a TAFKAL80ETC concert";
    private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
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
            if (item.Name != AGED_BRIE && item.Name != BACKSTAGE)
            {
                if (item.Quality > 0)
                {
                    if (item.Name != SULFURAS)
                    {
                        DecreaseQuality(item);
                    }
                }
            }
            else
            {
                if (item.Quality < MAX_QUALITY)
                {
                    item.Quality = item.Quality + 1;

                    if (item.Name == BACKSTAGE)
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < MAX_QUALITY)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < MAX_QUALITY)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }
                    }
                }
            }

            if (item.Name != SULFURAS)
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != AGED_BRIE)
                {
                    if (item.Name != BACKSTAGE)
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != SULFURAS)
                            {
                                DecreaseQuality(item);
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < MAX_QUALITY)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
        }
    }

    private static void DecreaseQuality(Item item)
    {
        item.Quality = item.Quality - 1;
    }
}