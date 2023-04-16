using DesignPatterns.Creational.Bridge;
using NUnit.Framework;

namespace DesignPatterns.Usages.Creational;

[TestFixture]
public class Bridge
{
    private string _taskWithReferenceDetails;
    private string _taskWithoutReferenceDetails;

    [OneTimeSetUp]
    public void Setup()
    {
        var taskWithReference = new TaskWithReference(new ReferenceBridgeTask())
        {
            Reference = Guid.Parse("7ffef1e3-59b9-447f-8014-a81e804c1016"),
            Description = "Task With Reference",
            Title = "Task With Reference",
            DueDate = new DateOnly(2023, 10, 02),
            IsComplete = false
        };

        var taskWithoutReference = new TaskWithoutReference(new NoReferenceBridgeTask())
        {
            Title = "Task Without Reference",
            Description = "Task Without Reference",
            DueDate = new DateOnly(2023, 10, 02),
            IsComplete = false
        };

        _taskWithReferenceDetails = taskWithReference.GetDetails();
        _taskWithoutReferenceDetails = taskWithoutReference.GetDetails();
    }

    [Test]
    public void Then()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_taskWithReferenceDetails, Is.EqualTo($"Reference 7ffef1e3-59b9-447f-8014-a81e804c1016 Title Task With Reference Description Task With Reference"));
            Assert.That(_taskWithoutReferenceDetails, Is.EqualTo($"Title Task Without Reference Description Task Without Reference"));
        });
    }
}