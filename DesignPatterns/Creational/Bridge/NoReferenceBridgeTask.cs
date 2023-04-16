namespace DesignPatterns.Creational.Bridge;

public sealed class NoReferenceBridgeTask : IBridgeTask
{
    public string GetDetails(TaskDetails taskDetails)
    {
        var userTask = taskDetails as TaskWithoutReference;

        if (userTask != null)
            return $"Title {userTask.Title} Description {userTask.Description}";

        return "";
    }
}