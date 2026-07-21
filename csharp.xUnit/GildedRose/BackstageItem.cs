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
            if (Quality < MAX_QUALITY)
            {
                IncreaseQuality();

                if (SellIn < 11)
                {
                    if (Quality < MAX_QUALITY)
                    {
                        IncreaseQuality();
                    }
                }

                if (SellIn < 6)
                {
                    if (Quality < MAX_QUALITY)
                    {
                        IncreaseQuality();
                    }
                }
            }

            DecreaseSellIn();

            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}
