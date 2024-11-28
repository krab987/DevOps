namespace DevOps.Tests;
using DevOps.Classes;
using DevOps.Enums;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;

public class TaskTest
{
    [Test]
    public void TitleTest()
    {
        Task task = new();
        string testTitle = "jkdgfbhgfwegyugq83u4fJNBHIGY*&R#Y(HR#*(IJOI))";
        task.Title = testTitle;
        ClassicAssert.AreEqual(testTitle, task.Title);
    }
    [Test]
    public void DescriptionTest()
    {
        Task task = new();
        string testDescription = "jkdgfbhgfwegyugq83u4fJNBHIGY*&R#Y(HR#*(IJOI))";
        task.Description = testDescription;
        ClassicAssert.AreEqual(testDescription, task.Description);
    }
    [Test]
    public void StatusTest()
    {
        Worker worker = new();
        Task task = new();
        worker.AddTask(task);
        worker.ChangeStatusTask(task, Status.Done);
        ClassicAssert.AreEqual(Status.Done, task.StatusTask);
    }
}