namespace Katas.GildedRose.Tests;

public class GildedRoseTests
{
    [Fact]
    public void _()
    {
        // Arrange.
        var item = new Item { Name = "test", Quality = 1, SellIn = 1 };
        var items = new List<Item> { item };
        var sut = new GildedRose(items);

        // Act.
        sut.UpdateQuality();

        // Assert.
        item.Quality.Equals(1);
    }
}