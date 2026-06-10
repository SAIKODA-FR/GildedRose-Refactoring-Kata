using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseTests
{
    internal class SpyItem : IItem
    {
        public bool WasCalled = false;

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SellIn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void UpdateQuality()
        {
            WasCalled = true;
        }
    }
}
