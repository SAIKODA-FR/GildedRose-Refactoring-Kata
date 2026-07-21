namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void DecreaseSellIn()
    {
        SellIn = SellIn - 1;
    }

    public void IncreaseQuality()
    {
        Quality = Quality + 1;
    }

    public void DecreaseQuality()
    {
        Quality = Quality - 1;
    }
}