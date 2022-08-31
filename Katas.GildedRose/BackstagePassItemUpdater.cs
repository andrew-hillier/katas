namespace Katas.GildedRose;

internal class BackstagePassItemUpdater : IItemUpdater
{
    public void UpdateQuality(Item item)
    {
        // todo
    }

    public void UpdateSellIn(Item item)
    {
        item.SellIn--;
    }
}