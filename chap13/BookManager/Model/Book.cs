namespace BookManager.Model;

internal class Book
{
    public required string Isbn { get; set; }
    public required string Name { get; set; }
    public required string Publisher { get; set; }
    public int Page { get; set; }


    public int UserId { get; set; }

    public string? UserName { get; set; }

    public bool IsBorrowed { get; set; }

    public DateTime? BorrowedAt { get; set; }
}

