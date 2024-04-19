using RepositoryPattern.Repository;

namespace RepositoryPattern.UnitTests;

[TestClass]
public class StreamingContentTests
{
    [TestMethod]
    public void SetTitle_ShouldSetCorrectString()
    {
        StreamingContent content = new StreamingContent();

        content.Title = "Toy Story";

        string expected = "Toy Story";
        string actual = content.Title;

        Assert.AreEqual(expected, actual);
    }
}