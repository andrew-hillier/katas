namespace Katas.GildedRose;

public abstract class BaseItemUpdater
{
    public abstract void UpdateQuality(Item item);
    public abstract void UpdateSellIn(Item item);

    protected void IncrementQuality(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality = item.Quality + 1;
        }
    }

    protected void DecrementQuality(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality--;
        }
    }
}