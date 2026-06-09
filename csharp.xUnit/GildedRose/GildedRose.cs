using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private const string AgedBrie = "Aged Brie";
    private const string BackStage = "Backstage passes to a TAFKAL80ETC concert";
    private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
    private const int MaxQuality = 50;

    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            var item = Items[i];
            if (item.Name != AgedBrie && item.Name != BackStage)
            {
                if (item.Quality > 0)
                {
                    if (item.Name != Sulfuras)
                    {
                        DecreaseQuality(item);
                    }
                }
            }
            else
            {
                if (item.Quality < MaxQuality)
                {
                    IncreaseQuality(item);

                    if (item.Name == BackStage)
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < MaxQuality)
                            {
                                IncreaseQuality(item);
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < MaxQuality)
                            {
                                IncreaseQuality(item);
                            }
                        }
                    }
                }
            }

            if (item.Name != Sulfuras)
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != AgedBrie)
                {
                    if (item.Name != BackStage)
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != Sulfuras)
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
                    if (item.Quality < MaxQuality)
                    {
                        IncreaseQuality(item);
                    }
                }
            }
        }
    }

    private void IncreaseQuality(Item item)
    {
        item.Quality = item.Quality + 1;
    }

    private void DecreaseQuality(Item item)
    {
        item.Quality = item.Quality - 1;
    }
}