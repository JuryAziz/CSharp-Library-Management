public class LibraryItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime DateCreated { get; set; }

    public LibraryItem(DateTime date = default)
    {
        DateCreated = date == default ? DateTime.Now : date;
    }
}