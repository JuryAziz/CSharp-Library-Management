public class User : LibraryItem
{
    string name { get; set; }

    public User(string name, DateTime date = default)
    {
        this.name = name;
        dateCreated = date == default ? DateTime.Now : date;
    }
}