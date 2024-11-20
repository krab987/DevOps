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
    string Position { get; set; } //Posiion like CEO, Tester etc.
    int Salary { get; set; } // Salary in dollars
    List<ITask> Tasks { get; }

    /// <summary>
    /// Add task to task list for worker
    /// </summary>
    /// <param name="task"> Task to add</param>
    void AddTask(ITask task);
    
    /// <summary>
    /// Changes status of selected Task from worker task list
    /// </summary>
    /// <param name="task">Task to change status of</param>
    /// <param name="status">Status to set</param>
    void ChangeStatusTask(ITask task, Status status );
    
    /// <summary>
    /// Delete task from worker task list
    /// </summary>
    /// <param name="id">Id of task to delete</param>
    /// <returns></returns>
    bool DeleteTaskAt(int id);



}