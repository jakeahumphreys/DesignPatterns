using DesignPatterns.Types;

namespace DesignPatterns.Creational.Prototype;

public sealed class CloneableTask : IProjectTask, ICloneable
{
    public Guid Reference { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateOnly DueDate { get; set; }
    public bool IsComplete { get; set; }

    public T Copy<T>() where T : IProjectTask
    {
        var clonedTask = (T) MemberwiseClone();
        clonedTask.Reference = Guid.NewGuid();
        return clonedTask;
    }

    object ICloneable.Clone()
    {
        return Copy<IProjectTask>();
    }
}