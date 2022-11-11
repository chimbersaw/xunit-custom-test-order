using Xunit;

namespace CustomTestOrder;

[TestCaseOrderer("CustomTestOrder.AlphabeticalOrderer", "CustomTestOrder")]
public class TestsInCollection1
{
    [Fact]
    public void A()
    {
        Thread.Sleep(1000);
    }

    [Fact]
    public void B()
    {
        Thread.Sleep(1000);
    }
}

public class TestsInCollection2
{
    [Fact]
    public void B()
    {
        Thread.Sleep(1000);
    }

    [Fact]
    public void C()
    {
        Thread.Sleep(1000);
    }
}

public class TestsInCollection3
{
    [Fact]
    public void A()
    {
        Thread.Sleep(1000);
    }

    [Fact]
    public void C()
    {
        Thread.Sleep(1000);
    }
}