using ComarchCwiczenia20250312.App.Cwiczenia;

namespace ComarchCwiczenia20250312.Unit.Tests.App.Cwiczenia;

[TestFixture]
public class KalkulatorTests
{
    private Kalkulator cut;

    [SetUp]
    public void Setup()
    {
        cut = new Kalkulator();
    }

    [Test]
    public void Add_Should_ReturnValidSum()
    {
        //Arrange
        int x = 2;
        int y = 3;
        int expected = 5;

        // Act
        int actual = cut.Add(x, y);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
