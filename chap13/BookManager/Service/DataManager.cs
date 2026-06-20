using System.Text;
using System.Xml.Linq;
using BookManager.Model;

namespace BookManager.Service;


internal class DataManager
{
    public static List<Book> Books = [];
    public static List<User> Users = [];

    // 데이터 변경 이벤트
    public static event EventHandler? DataChanged;

    static DataManager()
    {
        Load();
    }

    public static void Load()
    {
        try
        {
            var booksOutput = File.ReadAllText(@"./Books.xml");
            var booksXElement = XElement.Parse(booksOutput);
            Books = [.. (from item in booksXElement.Descendants("book")
                     select new Book
                     {
                         Isbn = item.Element("isbn")?.Value ?? string.Empty,
                         Name = item.Element("name")?.Value ?? string.Empty,
                         Publisher = item.Element("publisher")?.Value ?? string.Empty,
                         Page = int.Parse(item.Element("page")?.Value?? "0") ,
                         BorrowedAt = string.IsNullOrWhiteSpace(item.Element("borrowedAt")?.Value)
                             ? null
                             : DateTime.Parse(item.Element("borrowedAt")?.Value!),
                         IsBorrowed = item.Element("isBorrowed")?.Value  != "0",
                         UserId = int.Parse(item.Element("userId")?.Value ?? string.Empty),
                         UserName = item.Element("userName") ?.Value ?? string.Empty
                     })];

            var usersOutput = File.ReadAllText(@"./Users.xml");
            var usersXElement = XElement.Parse(usersOutput);
            Users = [.. (from item in usersXElement.Descendants("user")
                     select new User()
                     {
                         Id = int.Parse(item.Element("id")?.Value ?? string.Empty),
                         Name = item.Element("name")?.Value ?? string.Empty
                     })];
        }
        catch (FileNotFoundException)
        {
            Save();
        }
    }

    public static void Save()
    {
        var booksOutput = new StringBuilder("<books>\n");
        foreach (var item in Books)
        {
            booksOutput.Append("<book>\n");
            booksOutput.Append($"  <isbn>{item.Isbn}</isbn>\n");
            booksOutput.Append($"  <name>{item.Name}</name>\n");
            booksOutput.Append($"  <publisher>{item.Publisher}</publisher>\n");
            booksOutput.Append($"  <page>{item.Page}</page>\n");
            booksOutput.Append($"  <borrowedAt>{item.BorrowedAt?.ToString("o") ?? ""}</borrowedAt>\n");
            booksOutput.Append($"  <isBorrowed>{(item.IsBorrowed ? "1" : "0")}</isBorrowed>\n");
            booksOutput.Append($"  <userId>{item.UserId}</userId>\n");
            booksOutput.Append($"  <userName>{item.UserName ?? ""}</userName>\n");
            booksOutput.Append("</book>\n");
        }
        booksOutput.Append("</books>\n");

        var usersOutput = new StringBuilder("<users>\n");
        foreach (var item in Users)
        {
            usersOutput.Append("<user>\n");
            usersOutput.Append($"  <id>{item.Id}</id>\n");
            usersOutput.Append($"  <name>{item.Name}</name>\n");
            usersOutput.Append("</user>\n");
        }
        usersOutput.Append("</users>\n");

        File.WriteAllText(@"./Books.xml", booksOutput.ToString());
        File.WriteAllText(@"./Users.xml", usersOutput.ToString());
        // 저장 후 이벤트 발생
        DataChanged?.Invoke(null, EventArgs.Empty);
    }
}
