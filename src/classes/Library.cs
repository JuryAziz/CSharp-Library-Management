class Library(INotificationService? NotificationService = null)
{
    readonly INotificationService? NotificationService = NotificationService;
    public List<Book> Books { get; } = [];
    public List<User> Users { get; } = [];

    // Get all books with pagination, sorted by created date.
    public List<Book> GetAllBooks(int page, int pageLimit)
    {
        return Books.OrderBy(book => book.DateCreated).Skip((page - 1) * pageLimit).Take(pageLimit).ToList();
    }

    // Get all users with pagination, sorted by created date.
    public List<User> GetAllUsers(int page, int pageLimit)
    {
        return Users.OrderBy(user => user.DateCreated).Skip((page - 1) * pageLimit).Take(pageLimit).ToList();
    }

    // Find books by title
    public List<Book> FindBooksByTitle(string title)
    {
        return Books.FindAll(book => book.Title.ToUpper().Contains(title.ToUpper()));
    }

    // Find users by name
    public List<User> FindUsersByTitle(string name)
    {
        return Users.FindAll(user => user.Name.ToUpper().Contains(name.ToUpper()));
    }

    // Add new book to the library
    public bool AddBook(Book? book)
    {
        if (book is null) return false;
        if (Books.Exists(b => b.Id.Equals(book.Id))) return false;

        Books.Add(book);
        return true;
    }

    // Add new user to the library
    public bool AddUser(User? user)
    {
        if (user is null) return false;
        if (Users.Exists(u => u.Id.Equals(user.Id))) return false;

        Users.Add(user);
        return true;
    }

    // Delete book by id
    public bool DeleteBook(Guid id)
    {
        Book? book = Books.Find(book => book.Id.Equals(id));
        if (book is null) return false;

        Books.Remove(book);
        return true;
    }

    // Delete user by id
    public bool DeleteUser(Guid id)
    {
        User? user = Users.Find(user => user.Id.Equals(id));
        if (user is null) return false;

        Users.Remove(user);
        return true;
    }
}