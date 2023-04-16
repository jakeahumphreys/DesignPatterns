namespace DesignPatterns.Creational.Bridge;

public sealed class ReferenceBridgeTask : IBridgeTask
{
    public string GetDetails(TaskDetails taskDetails)
    {
        var adminTaskDetails = taskDetails as TaskWithReference;

        if (adminTaskDetails != null)
            return $"Reference {adminTaskDetails.Reference} Title {adminTaskDetails.Title} Description {adminTaskDetails.Description}";
       
        return "";
    }
}