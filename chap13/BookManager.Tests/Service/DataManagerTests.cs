using BookManager.Service;
using BookManager.Model;

namespace BookManager.Tests.Service;

public class DataManagerTests
{
    [Fact]
    public void Save_ShouldCreateXmlFiles()
    {
        // Arrange
        DataManager.Books.Add(new Book
        {
            Isbn = "123",
            Name = "Test Book",
            Publisher = "Test Publisher",
            Page = 500,
            UserId = 1,
            UserName = "Test User",
            IsBorrowed = true,
            BorrowedAt = DateTime.Now
        });

        DataManager.Users.Add(new User
        {
            Id = 1,
            Name = "Test User",
        });

        // Act
        DataManager.Save();

        // Assert
        Assert.True(File.Exists("./Books.xml"));
    }

    [Fact]
    public void Load_ShouldLoadBooksFromXml()
    {
        // Arrange & Act
        DataManager.Load();

        // Assert
        Assert.NotNull(DataManager.Books);
        Assert.NotNull(DataManager.Users);
    }
}
