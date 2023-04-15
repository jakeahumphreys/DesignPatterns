using DesignPatterns.Creational.Builder;
using DesignPatterns.Types;
using NUnit.Framework;

namespace DesignPatterns.Usages.Creational;

[TestFixture]
public class Builder
{
    private ProjectTask? _task;

    [OneTimeSetUp]
    public void Setup()
    {
        _task = new TaskBuilder()
            .WithReference(Guid.Parse("a0a20e30-6653-4970-ab61-a3a514593034"))
            .WithTitle("Example Task")
            .WithDescription("An example demonstrating the usage of the builder pattern")
            .WithDueDate(new DateOnly(2023, 10, 02))
            .IsComplete(false)
            .Build();
    }

    [Test]
    public void ThenTheTaskHasTheCorrectValues()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_task.Reference, Is.EqualTo(Guid.Parse("a0a20e30-6653-4970-ab61-a3a514593034")));
            Assert.That(_task.Title, Is.EqualTo("Example Task"));
            Assert.That(_task.Description, Is.EqualTo("An example demonstrating the usage of the builder pattern"));
            Assert.That(_task.DueDate, Is.EqualTo(new DateOnly(2023, 10, 02)));
            Assert.That(_task.IsComplete, Is.False);
        });
    }
}