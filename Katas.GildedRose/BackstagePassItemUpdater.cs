namespace Katas.GildedRose;

internal class BackstagePassItemUpdater : IItemUpdater
{
    public void UpdateQuality(Item item)
    {
        GildedRose.IncrementQuality(item);

        if (item.SellIn < 11)
        {
            GildedRose.IncrementQuality(item);
        }

        if (item.SellIn < 6)
        {
            GildedRose.IncrementQuality(item);
        }

        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }

    public void UpdateSellIn(Item item)
    {
        item.SellIn--;
    }
}