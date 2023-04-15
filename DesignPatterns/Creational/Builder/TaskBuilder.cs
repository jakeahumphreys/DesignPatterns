using System.ComponentModel;
using DesignPatterns.Types;

namespace DesignPatterns.Creational.Builder;

[Description("An example of the Builder creational pattern")]

public interface ITaskBuilder
{
    public TaskBuilder WithReference(Guid reference);
    public TaskBuilder WithTitle(string title);
    public TaskBuilder WithDescription(string description);
    public TaskBuilder WithDueDate(DateOnly dueDate);
    public TaskBuilder IsComplete(bool isComplete);
    public ProjectTask Build();
}

public sealed class TaskBuilder : ITaskBuilder
{
    private readonly ProjectTask _projectTask;
    
    public TaskBuilder()
    {
        _projectTask = new ProjectTask();
    }

    public TaskBuilder WithReference(Guid reference)
    {
        _projectTask.Reference = reference;
        return this;
    }

    public TaskBuilder WithTitle(string title)
    {
        _projectTask.Title = title;
        return this;
    }

    public TaskBuilder WithDescription(string description)
    {
        _projectTask.Description = description;
        return this;
    }

    public TaskBuilder WithDueDate(DateOnly dueDate)
    {
        _projectTask.DueDate = dueDate;
        return this;
    }

    public TaskBuilder IsComplete(bool isComplete)
    {
        _projectTask.IsComplete = isComplete;
        return this;
    }

    public ProjectTask Build()
    {
        return _projectTask;
    }
}