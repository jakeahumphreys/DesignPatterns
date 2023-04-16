namespace DesignPatterns.Creational.Bridge;

public sealed class TaskWithReference : TaskDetails
{
    public Guid Reference { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateOnly DueDate { get; set; }
    public bool IsComplete { get; set; }
    
    public TaskWithReference(IBridgeTask bridgeTask) : base(bridgeTask)
    {
    }

    public override string GetDetails()
    {
        return BridgeTask.GetDetails(this);
    }
}