namespace DevOps.Tests;
using DevOps.Classes;
using DevOps.Enums;
using NUnit.Framework.Internal;

public class TaskTest
{
    [Test]
    public void TitleTest()
    {
        Task task = new();
        string testTitle = "jkdgfbhgfwegyugq83u4fJNBHIGY*&R#Y(HR#*(IJOI))";
        task.Title = testTitle;
        Assert.Equals(testTitle, task.Title);
    }
    [Test]
    public void DescriptionTest()
    {
        Task task = new();
        string testDescription = "jkdgfbhgfwegyugq83u4fJNBHIGY*&R#Y(HR#*(IJOI))";
        task.Description = testDescription;
        Assert.Equals(testDescription, task.Description);
    }
    [Test]
    public void StatusTest()
    {
        Worker worker = new();
        Task task = new();
        worker.ChangeStatusTask(task, Status.Done);
        Assert.Equals(Status.Done, task.StatusTask);
    }
}