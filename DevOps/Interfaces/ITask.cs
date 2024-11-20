using DevOps.Enums;

namespace DevOps.Interfaces;

/// <summary>
/// Interfase interprets classic task in it work, here is classic kanban statuses
/// </summary>
public interface ITask
{
    string Title { get; set; }
    string Description { get; set; }
    Status StatusTask { get; }

}