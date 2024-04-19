using RepositoryPattern.Repository;

namespace RepositoryPattern.UnitTests;

[TestClass]
public class RepositoryPatternUnitTests
{
    private StreamingContentRepository _repo;
    private StreamingContent _content;

    [TestInitialize]
    public void Arrange()
    {
        _repo = new StreamingContentRepository();
        _content = new StreamingContent("The Blob", "Gelatinous alien life form takes over a small town.", "PG", 4.6, false, GenreType.SciFi);

        _repo.AddContentToList(_content);
    }

    // Add Method
    [TestMethod]
    public void AddToList_ShouldGetNotNull()
    {
        // Arrange --> Setting up the playing field
        StreamingContent content = new StreamingContent();
        content.Title = "Toy Story";
        StreamingContentRepository repository = new StreamingContentRepository();

        // Act --> Get/run the corde we want to test
        repository.AddContentToList(content);
        StreamingContent contentFromDirectory = repository.GetContentByTitle("Toy Story");

        // Assert --> Use the assert class to verify the expected outcome
        Assert.IsNotNull(contentFromDirectory);
    }

    // Update
    [TestMethod]
    public void UpdateExistingContent_ShouldReturnTrue()
    {
        // Arrange

        // TestInitialize //! Update information from that used in helper method
        StreamingContent newContent = new StreamingContent("The Blob", "Gelatinous alien life form takes over a small town.", "PG", 8.9, true, GenreType.SciFi);

        // Act
        bool updateResult = _repo.UpdateExistingContent("The Blob", newContent);

        // Assert
        Assert.IsTrue(updateResult);
    }

    [TestMethod]
    [DataRow("The Blob", true)]
    [DataRow("Toy Story", false)]
    public void UpdateExistingContent_ShouldMatchGivenBool(string originalTitle, bool shouldUpdate)
    {
        // Arrange

        // TestInitialize //! Update information from that used in helper method
        StreamingContent newContent = new StreamingContent("The Blob", "Gelatinous alien life form takes over a small town.", "PG", 8.9, true, GenreType.SciFi);

        // Act
        bool updateResult = _repo.UpdateExistingContent(originalTitle, newContent);

        // Assert
        Assert.AreEqual(shouldUpdate, updateResult);
    }

    [TestMethod]
    public void DeleteContent_ShouldReturnTrue()
    {
        // Arrange

        // Act
        bool deleteResult = _repo.RemoveContentFromList(_content.Title);

        // Assert
        Assert.IsTrue(deleteResult);
    }
}