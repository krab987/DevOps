using DevOps.Enums;
using DevOps.Interfaces;

public class Worker : IWorker
{
    public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public List<ITask> Tasks => throw new NotImplementedException();

    public void AddTask(ITask task)
    {
        throw new NotImplementedException();
    }

    public void ChangeStatusTask(ITask task, Status status)
    {
        throw new NotImplementedException();
    }

    public bool DeleteTaskAt(int id)
    {
        throw new NotImplementedException();
    }
}