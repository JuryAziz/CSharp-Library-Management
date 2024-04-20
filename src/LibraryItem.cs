public class LibraryItem
{
    public Guid id { get; set; } = Guid.NewGuid();
    public DateTime dateCreated { get; set; }

    public LibraryItem(DateTime date = default)
    {
        dateCreated = date == default ? DateTime.Now : date;
    }
}