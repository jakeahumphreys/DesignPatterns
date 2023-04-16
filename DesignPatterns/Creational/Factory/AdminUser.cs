namespace DesignPatterns.Creational.Factory;

public sealed class AdminUser : User
{
    public override void SetPermissions()
    {
        Permissions.Add(new CanCreateTask(true));
        Permissions.Add(new CanDeleteTasksFromOthers(true));
    }
}