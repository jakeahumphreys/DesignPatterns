namespace DesignPatterns.Creational.Bridge;

public abstract class TaskDetails
{
    protected IBridgeTask BridgeTask;

    public TaskDetails(IBridgeTask bridgeTask)
    {
        BridgeTask = bridgeTask;
    }

    public abstract string GetDetails();
}