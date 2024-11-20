using DevOps.Enums;

namespace DevOps.Interfaces;

/// <summary>
/// Worker class interpreet classic worker that have own tasks 
/// </summary>
public interface IWorker
{
    string FirstName { get; set; }
    string LastName { get; set; }
    int Age { get; set; }
    int Telephone { get; set; } //Ukraine telephone number
    int Salary { get; set; } // Salary in dollars
    List<ITask> Tasks { get; }

    void AddTask(ITask task);
    void ChangeStatusTask(ITask task, Status status );

    bool DeleteTaskAt(int id);



}