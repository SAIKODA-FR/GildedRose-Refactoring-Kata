using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<IItem> Items;

    public GildedRose(IList<IItem> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            item.UpdateQuality();
        }
    }

    

}