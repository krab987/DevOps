using DevOps.Enums;

namespace DevOps.Interfaces;

public interface IWorker
{
    string FirstName { get; set; }
    string LastName { get; set; }
    int Age { get; set; }
    int Telephone { get; set; }
    int Salary { get; set; }
    List<ITask> Tasks { get; }

    void AddTask(ITask task);
    void ChangeStatusTask(ITask task, Status status );

    bool DeleteTaskAt(int id);



}