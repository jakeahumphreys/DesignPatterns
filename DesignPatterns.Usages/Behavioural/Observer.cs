using DesignPatterns.Behavioural.Observer;
using NUnit.Framework;

namespace DesignPatterns.Usages.Behavioural;

[TestFixture]
public sealed class Observer
{
    private Subscriber _subscriber;

    [OneTimeSetUp]
    public void Setup()
    {
        _subscriber = new Subscriber("jhumphreys");
        var projectTask = new ObservableTask("Test Task", "Test Observable Task", 1);
        projectTask.Subscribe(_subscriber);
        
        projectTask.SetEstimatedHours(2);
        projectTask.SetEstimatedHours(7);
        projectTask.SetIsCompleted(true);
    }
    
    [Test]
    public void Then()
    {
        var notifications = _subscriber.GetNotifications();
        Assert.Multiple(() =>
        {
            Assert.That(notifications, Has.Count.EqualTo(3));
            Assert.That(notifications[0].GetNotificationMessage(), Is.EqualTo($"Task estimated hours updated to 2"));
            Assert.That(notifications[1].GetNotificationMessage(), Is.EqualTo($"Task estimated hours updated to 7"));
            Assert.That(notifications[2].GetNotificationMessage(), Is.EqualTo($"Task completion status set to True"));
        });
    }
}