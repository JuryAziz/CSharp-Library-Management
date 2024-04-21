internal class Program
{
    private static void Main()
    {
        // Program.cs - You can also change these sample codes to adapt to your design
        var user1 = new User("Alice", new DateTime(2023, 1, 1));
        var user2 = new User("Bob", new DateTime(2023, 2, 1));
        var user3 = new User("Charlie", new DateTime(2023, 3, 1));
        var user4 = new User("David", new DateTime(2023, 4, 1));
        var user5 = new User("Eve", new DateTime(2024, 5, 1));
        var user6 = new User("Fiona", new DateTime(2024, 6, 1));
        var user7 = new User("George", new DateTime(2024, 7, 1));
        var user8 = new User("Hannah", new DateTime(2024, 8, 1));
        var user9 = new User("Ian");
        var user10 = new User("Julia");

        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book2 = new Book("1984", new DateTime(2023, 2, 1));
        var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
        var book4 = new Book("The Catcher in the Rye", new DateTime(2023, 4, 1));
        var book5 = new Book("Pride and Prejudice", new DateTime(2023, 5, 1));
        var book6 = new Book("Wuthering Heights", new DateTime(2023, 6, 1));
        var book7 = new Book("Jane Eyre", new DateTime(2023, 7, 1));
        var book8 = new Book("Brave New World", new DateTime(2023, 8, 1));
        var book9 = new Book("Moby-Dick", new DateTime(2023, 9, 1));
        var book10 = new Book("War and Peace", new DateTime(2023, 10, 1));
        var book11 = new Book("Hamlet", new DateTime(2023, 11, 1));
        var book12 = new Book("Great Expectations", new DateTime(2023, 12, 1));
        var book13 = new Book("Ulysses", new DateTime(2024, 1, 1));
        var book14 = new Book("The Odyssey", new DateTime(2024, 2, 1));
        var book15 = new Book("The Divine Comedy", new DateTime(2024, 3, 1));
        var book16 = new Book("Crime and Punishment", new DateTime(2024, 4, 1));
        var book17 = new Book("The Brothers Karamazov", new DateTime(2024, 5, 1));
        var book18 = new Book("Don Quixote", new DateTime(2024, 6, 1));
        var book19 = new Book("The Iliad");
        var book20 = new Book("Anna Karenina");


        Library SMS_Library = new(new SMSNotificationService());

        SMS_Library.AddBook(book1);
        SMS_Library.AddBook(book2);
        SMS_Library.AddBook(book3);
        SMS_Library.AddBook(book4);
        SMS_Library.AddBook(book5);
        SMS_Library.AddBook(book6);
        SMS_Library.AddBook(book7);
        SMS_Library.AddBook(book8);
        SMS_Library.AddBook(book9);
        SMS_Library.AddBook(book10);

        SMS_Library.AddUser(user1);
        SMS_Library.AddUser(user2);
        SMS_Library.AddUser(user3);
        SMS_Library.AddUser(user4);
        SMS_Library.AddUser(user5);

        Console.WriteLine($"SMS Library's Books count: {SMS_Library.Books.Count}");
        Console.WriteLine($"SMS Library's Users count: {SMS_Library.Users.Count}");
        Console.WriteLine($"SMS Library's Books: {String.Join(", ", SMS_Library.GetAllBooks(1, 5).Select(book => book.Title))}");
        Console.WriteLine($"SMS Library's Users: {String.Join(", ", SMS_Library.GetAllUsers(1, 2).Select(user => user.Name))}");


        Library Email_Library = new(new EmailNotificationService());

        Email_Library.AddBook(book11);
        Email_Library.AddBook(book12);
        Email_Library.AddBook(book13);
        Email_Library.AddBook(book14);
        Email_Library.AddBook(book15);
        Email_Library.AddBook(book16);
        Email_Library.AddBook(book17);
        Email_Library.AddBook(book18);
        Email_Library.AddBook(book19);
        Email_Library.AddBook(book20);

        Email_Library.AddUser(user6);
        Email_Library.AddUser(user7);
        Email_Library.AddUser(user8);
        Email_Library.AddUser(user9);
        Email_Library.AddUser(user10);

        Console.WriteLine($"Email Library's Books count: {Email_Library.Books.Count}");
        Console.WriteLine($"Email Library's Users count: {Email_Library.Users.Count}");
        Console.WriteLine($"Email Library's Books: {String.Join(", ", Email_Library.GetAllBooks(1, 5).Select(book => book.Title))}");
        Console.WriteLine($"Email Library's Users: {String.Join(", ", Email_Library.GetAllUsers(1, 2).Select(user => user.Name))}");
    }
}