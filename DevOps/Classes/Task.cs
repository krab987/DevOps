
namespace DevOps.Classes;

using DevOps.Enums;
using DevOps.Interfaces;

public class Task : ITask
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Status StatusTask { get; set; }


    public Task(int id, string title, string description, Status statusTask)
    {

        Id = id;
        Title = title;
        Description = description;
        StatusTask = statusTask;
    }
    public Task()
    {

        Id = 0;
        Title = string.Empty;
        Description = string.Empty;
        StatusTask = Status.ToDo;
    }
}