namespace DevOps.Tests;
using DevOps.Classes;
using DevOps.Enums;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

public class WorkerTaskTest
{
    [Test]
    public void TaskTest1()
    {
        Worker worker = new();
        Task task = new();
        worker.AddTask(task);
        Assert.Equals(task, worker.Tasks.First());
    }
    [Test]
    public void TaskTest2()
    {
        Worker worker = new();
        Task task = new();
        Task task2 = new();
        worker.AddTask(task);
        worker.AddTask(task2);
        worker.DeleteTaskAt(0);
        Assert.Equals(task2, worker.Tasks.First());
    }
}