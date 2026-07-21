using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseTests
{
    internal class ItemBuilder
    {
        private int? _quality;
        private int? _sellin;

        public ItemBuilder WithQuality(int quality)
        {
            _quality = quality;
            return this;
        }

        public ItemBuilder WithSellin(int sellin)
        {
            _sellin = sellin;
            return this;
        }

        public Item Build()
        {
            Item item = new () { Name = "", Quality = _quality ?? 1, SellIn = _sellin ?? 1 };
            return item;
        }
    }
}
