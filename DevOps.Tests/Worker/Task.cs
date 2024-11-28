namespace DevOps.Tests;
using DevOps.Classes;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;
using NUnit.Framework;

public class WorkerTaskTest
{
    [Test]
    public void TaskTest1()
    {
        Worker worker = new();
        Task task = new();
        worker.AddTask(task);
        Assert.That(worker.Tasks.First(), Is.EqualTo(task));
    }
    [Test]
    public void TaskTest2()
    {
        Worker worker = new();
        Task task = new();
        Task task2 = new();
        worker.AddTask(task);
        worker.AddTask(task2);
        _ = worker.DeleteTaskAt(0);
        Assert.That(worker.Tasks.First(), Is.EqualTo(task2));
    }
}