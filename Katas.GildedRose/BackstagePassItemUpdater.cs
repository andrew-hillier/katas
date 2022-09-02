namespace Katas.GildedRose;

internal class BackstagePassItemUpdater : BaseItemUpdater
{
    public override void UpdateQuality(Item item)
    {
        IncrementQuality(item);

        if (item.SellIn < 11)
        {
            IncrementQuality(item);
        }

        if (item.SellIn < 6)
        {
            IncrementQuality(item);
        }

        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }

    public override void UpdateSellIn(Item item)
    {
        item.SellIn--;
    }
}