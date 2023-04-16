namespace DesignPatterns.Creational.Bridge;

public sealed class TaskWithoutReference : TaskDetails
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateOnly DueDate { get; set; }
    public bool IsComplete { get; set; }


    public TaskWithoutReference(IBridgeTask bridgeTask) : base(bridgeTask)
    {
    }

    public override string GetDetails()
    {
        return BridgeTask.GetDetails(this);
    }
}