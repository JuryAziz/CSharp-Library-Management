public class Book : LibraryItem
{
    string title { get; set; }

    public Book(string title, DateTime date = default)
    {
        this.title = title;
        dateCreated = date == default ? DateTime.Now : date;
    }
}