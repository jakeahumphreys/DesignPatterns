namespace DesignPatterns.Behavioural.Observer;

public interface ISubscriber
{
    void Update(Notification notification);
}

public class Subscriber : ISubscriber
{
    private readonly List<Notification> _notifications = new List<Notification>();
    private string Username { get; set; }

    public Subscriber(string username)
    {
        Username = username;
    }

    public List<Notification> GetNotifications()
    {
        return _notifications;
    }
    
    public void Update(Notification notification)
    {
        _notifications.Add(notification);
    }
}