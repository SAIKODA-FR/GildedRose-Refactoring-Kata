namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void ResetQuality()
    {
        Quality = 0;
    }

    public void DecreaseQuality()
    {
        if (Quality > 0)
        {
            Quality = Quality - 1;
        }
    }

    public void DecreaseSellin()
    {
        SellIn = SellIn - 1;
    }

    public void IncreaseQuality()
    {
        Quality = Quality + 1;
    }
}