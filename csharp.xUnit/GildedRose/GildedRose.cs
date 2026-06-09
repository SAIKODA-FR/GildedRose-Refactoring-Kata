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
        foreach (var item in Items)
        {
            UpdateQualityAndSellin(item);
        }
    }

    private void UpdateQualityAndSellin(Item item)
    {
        if (item.Name != AgedBrie && item.Name != BackStage)
        {
            if (item.Name != Sulfuras)
            {
                item.DecreaseQuality();
            }
        }
        else
        {
            if (item.Quality < MaxQuality)
            {
                item.IncreaseQuality();

                if (item.Name == BackStage)
                {
                    if (item.SellIn < 11)
                    {
                        if (item.Quality < MaxQuality)
                        {
                            item.IncreaseQuality();
                        }
                    }

                    if (item.SellIn < 6)
                    {
                        if (item.Quality < MaxQuality)
                        {
                            item.IncreaseQuality();
                        }
                    }
                }
            }
        }

        if (item.Name != Sulfuras)
        {
            item.DecreaseSellin();
        }

        if (item.SellIn < 0)
        {
            if (item.Name != AgedBrie)
            {
                if (item.Name != BackStage)
                {
                    if (item.Name != Sulfuras)
                    {
                        item.DecreaseQuality();
                    }
                }
                else
                {
                    item.ResetQuality();
                }
            }
            else
            {
                if (item.Quality < MaxQuality)
                {
                    item.IncreaseQuality();
                }
            }
        }
    }    
}