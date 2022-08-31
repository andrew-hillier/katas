namespace Katas.GildedRose;

public class GildedRose
{
    IList<Item> Items;
    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        var itemUpdaterFactory = new ItemUpdaterFactory();

        foreach (Item item in Items)
        {
            var itemUpdater = itemUpdaterFactory.Create(item.Name);

            itemUpdater.UpdateQuality(item);
            itemUpdater.UpdateSellIn(item);

            if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    DecrementQuality(item);
                }
            }
            else
            {
                IncrementQuality(item);

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.SellIn < 11)
                    {
                        IncrementQuality(item);
                    }

                    if (item.SellIn < 6)
                    {
                        IncrementQuality(item);
                    }
                }
            }

            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.Name != "Sulfuras, Hand of Ragnaros")
                        {
                            DecrementQuality(item);
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    IncrementQuality(item);
                }
            }
        }

    }

    private static void IncrementQuality(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality = item.Quality + 1;
        }
    }

    private static void DecrementQuality(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality--;
        }
    }
}