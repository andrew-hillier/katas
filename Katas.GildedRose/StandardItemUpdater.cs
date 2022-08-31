namespace Katas.GildedRose;

internal class StandardItemUpdater : IItemUpdater
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