namespace Katas.GildedRose;

internal class StandardItemUpdater : BaseItemUpdater
{
    public override void UpdateQuality(Item item)
    {
        DecrementQuality(item);

        if (item.SellIn < 0)
        {
            DecrementQuality(item);
        }
    }

    public override void UpdateSellIn(Item item)
    {
        item.SellIn--;
    }
}
