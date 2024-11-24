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
    public void StatusTest() // Nothing to test yet
    {
        Assert.Fail();
    }
}