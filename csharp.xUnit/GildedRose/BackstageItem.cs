using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    internal class BackstageItem : Item
    {
        public BackstageItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {

            IncreaseQuality();

            if (SellIn < 11)
            {
                IncreaseQuality();
            }

            if (SellIn < 6)
            {
                IncreaseQuality();
            }

            DecreaseSellIn();

            if (SellIn < 0)
            {
                SetMinimumQuality();
            }
        }
    }
}
