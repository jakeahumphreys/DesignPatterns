﻿namespace DesignPatterns.Types;

public class ProjectTask : IProjectTask
{
    public Guid Reference { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateOnly DueDate { get; set; }
    public bool IsComplete { get; set; }
}