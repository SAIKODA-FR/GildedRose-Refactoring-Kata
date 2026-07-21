namespace GildedRoseKata;

public abstract class Item
{
    protected const int MAX_QUALITY = 50;
    protected const int MIN_QUALITY = 0;
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

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