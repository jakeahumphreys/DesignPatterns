namespace DesignPatterns.Creational.Factory;

public sealed class StandardUser : User
{
    public override void SetPermissions()
    {
        Permissions.Add(new CanCreateTask(true));
        Permissions.Add(new CanDeleteTasksFromOthers(false));
    }
}