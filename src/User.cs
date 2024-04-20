public class User : LibraryItem
{
    public string Name { get; set; }

    public User(string name, DateTime date = default)
    {
        Name = name;
        DateCreated = date == default ? DateTime.Now : date;
    }
}