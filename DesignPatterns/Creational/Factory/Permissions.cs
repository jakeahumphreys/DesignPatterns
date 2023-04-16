namespace DesignPatterns.Creational.Factory;

public class CanCreateTask : Permission
{
    public CanCreateTask(bool value)
    {
        Key = "CanCreateTasks";
        Value = value;
    }
}

public class CanDeleteTasksFromOthers : Permission
{
    public CanDeleteTasksFromOthers(bool value)
    {
        Key = "CanDeleteTasksFromOthers";
        Value = value;
    }
}