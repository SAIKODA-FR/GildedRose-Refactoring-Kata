namespace GildedRoseKata;

public abstract class Item
{
    protected const int MAX_QUALITY = 50;
    protected const int MIN_QUALITY = 0;
    public string Name { get; private set; }
    public int SellIn { get; private set; }
    public int Quality { get; protected set; }

    protected Item(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    protected void DecreaseSellIn()
    {
        SellIn = SellIn - 1;
    }

    protected void IncreaseQuality()
    {
        Quality = Quality + 1;
    }

    protected void DecreaseQuality()
    {
        Quality = Quality - 1;
    }

    public abstract void UpdateQuality();

}