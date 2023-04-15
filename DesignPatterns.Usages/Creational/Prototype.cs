using DesignPatterns.Creational.Prototype;
using DesignPatterns.Types;
using NUnit.Framework;

namespace DesignPatterns.Usages.Creational;

[TestFixture]
public class Prototype
{
    private CloneableTask? _task;
    private IProjectTask? _clonedTask;

    [OneTimeSetUp]
    public void Setup()
    {
        _task = new CloneableTask
        {
            Reference = Guid.NewGuid(),
            Title = "Test Cloneable Task",
            Description = "An example of using the prototype pattern to clone objects",
            DueDate = new DateOnly(2023, 10, 02),
            IsComplete = false
        };

        _clonedTask = _task.Copy<IProjectTask>();
    }

    [Test]
    public void Then()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_clonedTask?.Reference, Is.Not.EqualTo(_task.Reference));
            Assert.That(_clonedTask?.Title, Is.EqualTo(_task.Title));
            Assert.That(_clonedTask?.Description, Is.EqualTo(_task.Description));
            Assert.That(_clonedTask?.DueDate, Is.EqualTo(_task.DueDate));
            Assert.That(_clonedTask?.IsComplete, Is.EqualTo(_task.IsComplete));
        });
    }
}