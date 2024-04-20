public class Book : LibraryItem
{
    public string Title { get; set; }

    public Book(string title, DateTime date = default)
    {
        Title = title;
        DateCreated = date == default ? DateTime.Now : date;
    }
}