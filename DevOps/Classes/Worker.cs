
namespace DevOps.Classes;

using System.Text.RegularExpressions;
using DevOps.Enums;
using DevOps.Interfaces;

public class Worker : IWorker
{
    private int _age;
    private string _firstName = string.Empty;
    private string _lastName = string.Empty;

    public Guid Id { get; set; } = Guid.NewGuid();

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (!IsValidName(value))
            {
                throw new ArgumentException("First name contains invalid characters.");
            }
            _firstName = value;
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (!IsValidName(value))
            {
                throw new ArgumentException("Last name contains invalid characters.");
            }
            _lastName = value;
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentException(nameof(value), "Age must be between 0 and 120.");
            }
            _age = value;
        }
    }

    public string Position { get; set; } = string.Empty;
    public int Salary { get; set; }
    public List<ITask> Tasks { get; } = new List<ITask>();

    public void AddTask(ITask task)
    {
        if (task != null)
        {
            Tasks.Add(task);
        }
    }

    public void ChangeStatusTask(ITask task, Status status)
    {
        if (task != null && Tasks.Contains(task))
        {
            task.StatusTask = status;
        }
    }

    public bool DeleteTaskAt(int id)
    {
        var task = Tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            _ = Tasks.Remove(task);
            return true;
        }
        return false;
    }

    private bool IsValidName(string name)
    {
        return Regex.IsMatch(name, "^[a-zA-Z\\s']+$");
    }
}