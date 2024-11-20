using DevOps.Enums;

namespace DevOps.Interfaces;

public interface ITask
{
    string Title { get; set; }
    string Description { get; set; }
    Status StatusTask { get; }

}