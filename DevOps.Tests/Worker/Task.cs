namespace DevOps.Tests;
using DevOps.Classes;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;

public class WorkerTaskTest
{
    [Test]
    public void TaskTest1()
    {
        Worker worker = new();
        Task task = new();
        worker.AddTask(task);
        ClassicAssert.AreEqual(task, worker.Tasks.First());
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
        ClassicAssert.AreEqual(task2, worker.Tasks.First());
    }
}