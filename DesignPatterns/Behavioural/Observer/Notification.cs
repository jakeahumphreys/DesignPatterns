namespace DesignPatterns.Behavioural.Observer;

public class Notification
{
    private string _message;
    private List<ISubscriber> _subscribers = new List<ISubscriber>();

    public Notification(string message)
    {
        _message = message;
    }

    public string GetNotificationMessage()
    {
        return _message;
    }
}