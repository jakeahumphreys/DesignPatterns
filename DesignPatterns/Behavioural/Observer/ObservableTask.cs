using DesignPatterns.Types;

namespace DesignPatterns.Behavioural.Observer;

public sealed class ObservableTask : IProjectTask
{
    public Guid Reference { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int EstimatedHours { get; set; }
    public DateOnly DueDate { get; set; }
    public bool IsComplete { get; set; }

    private List<ISubscriber> _subscribers = new List<ISubscriber>();

    public ObservableTask(string title, string description, int estimatedHours)
    {
        Reference = Guid.NewGuid();
        Title = title;
        Description = description;
        EstimatedHours = estimatedHours;
        DueDate = new DateOnly(2023, 10, 02);
        IsComplete = false;
    }
    
    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void SetEstimatedHours(int estimatedHours)
    {
        EstimatedHours = estimatedHours;
        Notify($"Task estimated hours updated to {estimatedHours}");
    }

    public void SetIsCompleted(bool isComplete)
    {
        IsComplete = isComplete;
        Notify($"Task completion status set to {isComplete}");
    }

    private void Notify(string message)
    {
        foreach(var subscriber in _subscribers)
            subscriber.Update(new Notification(message));
    }
}