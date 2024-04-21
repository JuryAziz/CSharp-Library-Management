interface INotificationService
{
    void SendNotificationOnSuccess(string msg);
    void SendNotificationOnFailure(string msg);
}

class EmailNotificationService : INotificationService
{
    public void SendNotificationOnSuccess(string msg)
    {
        Console.WriteLine($"Email notification. \n hurry! action successful. thank you for using our Email notification service.");
    }

    public void SendNotificationOnFailure(string msg)
    {
        Console.WriteLine($"Email notification. \n sorry! action failed. thank you for using our Email notification service.");
    }
}

class SMSNotificationService : INotificationService
{
    public void SendNotificationOnSuccess(string msg)
    {
        Console.WriteLine($"SMS notification. \n hurry! action successful. thank you for using our SMS notification service.");
    }

    public void SendNotificationOnFailure(string msg)
    {
        Console.WriteLine($"SMS notification. \n sorry! action failed. thank you for using our SMS notification service.");
    }
}