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
            if (Items[i].Name != AgedBrie && Items[i].Name != BackStage)
            {
                if (Items[i].Quality > 0)
                {
                    if (Items[i].Name != Sulfuras)
                    {
                        DecreaseQuality(i);
                    }
                }
            }
            else
            {
                if (Items[i].Quality < MaxQuality)
                {
                    IncreaseQuality(i);

                    if (Items[i].Name == BackStage)
                    {
                        if (Items[i].SellIn < 11)
                        {
                            if (Items[i].Quality < MaxQuality)
                            {
                                IncreaseQuality(i);
                            }
                        }

                        if (Items[i].SellIn < 6)
                        {
                            if (Items[i].Quality < MaxQuality)
                            {
                                IncreaseQuality(i);
                            }
                        }
                    }
                }
            }

            if (Items[i].Name != Sulfuras)
            {
                Items[i].SellIn = Items[i].SellIn - 1;
            }

            if (Items[i].SellIn < 0)
            {
                if (Items[i].Name != AgedBrie)
                {
                    if (Items[i].Name != BackStage)
                    {
                        if (Items[i].Quality > 0)
                        {
                            if (Items[i].Name != Sulfuras)
                            {
                                DecreaseQuality(i);
                            }
                        }
                    }
                    else
                    {
                        Items[i].Quality = Items[i].Quality - Items[i].Quality;
                    }
                }
                else
                {
                    if (Items[i].Quality < MaxQuality)
                    {
                        IncreaseQuality(i);
                    }
                }
            }
        }
    }

    private void IncreaseQuality(int i)
    {
        Items[i].Quality = Items[i].Quality + 1;
    }

    private void DecreaseQuality(int i)
    {
        Items[i].Quality = Items[i].Quality - 1;
    }
}