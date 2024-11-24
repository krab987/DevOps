namespace DevOps.Classes;

using DevOps.Enums;
using DevOps.Interfaces;

public class Task : ITask
{
    public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Status StatusTask => throw new NotImplementedException();
}