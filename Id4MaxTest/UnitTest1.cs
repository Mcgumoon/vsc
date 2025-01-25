using Id4Max; // Correctly include the namespace where the Id class is defined

namespace Id4MaxTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double x = 6;
        double y = 3;
        double expected = 6;
        double actual = Id.Max(x, y); // Correct reference to Id.Max
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2(){
        double x = 237;
        double y = 102;
        double expected = 237;
        double actual = Id.Max(x, y); // Correct reference to Id.Max
        Assert.Equal(expected, actual);
    }
}
