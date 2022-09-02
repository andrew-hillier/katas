namespace Katas.GildedRose;

internal class ConjuredItemUpdater : BaseItemUpdater
{
    public override void UpdateQuality(Item item)
    {
        DecrementQuality(item);
        DecrementQuality(item);

        if (item.SellIn < 0)
        {
            DecrementQuality(item);
            DecrementQuality(item);
        }
    }

    public override void UpdateSellIn(Item item)
    {
        item.SellIn--;
    }
}