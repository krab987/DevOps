namespace DevOps.Tests;
using DevOps.Classes;
using NUnit.Framework.Internal;

public class WorkerGetSetTest
{
    [Test]
    public void FirstNameTestSymbols()
    {
        // We cant have random symbols in name. Apostrophe and whitespace should be allowed
        Worker worker = new();
        string testName = "gdfjnghdbhfiajskldsgdfsNGUY&T^(*Y(UHIGHGYOUHJO))";
        _ = Assert.Throws<ArgumentException>(() => worker.FirstName = testName);
    }
    [Test]
    public void FirstNameTest()
    {
        Worker worker = new();
        string testName = "Sdsjnoihufheruifsd";
        worker.FirstName = testName;
        Assert.That(worker.FirstName, Is.EqualTo(testName));
    }
    [Test]
    public void LastNameTestSymbols()
    {
        // We cant have random symbols in name. Apostrophe and whitespace should be allowed
        Worker worker = new();
        string testName = "gdfjnghdbhfiajskldsgdfsNGUY&T^(*Y(UHIGHGYOUHJO))";
        _ = Assert.Throws<ArgumentException>(() => worker.LastName = testName);
    }
    [Test]
    public void LastNameTest()
    {
        Worker worker = new();
        string testName = "Sdsjnoihufheruifsd";
        worker.LastName = testName;
        Assert.That(worker.LastName, Is.EqualTo(testName));
    }
    [Test]
    public void AgeTestBig()
    {
        Worker worker = new();
        int testAge = 150;
        _ = Assert.Throws<ArgumentException>(() => worker.Age = testAge);
    }
    [Test]
    public void TestAge()
    {
        Worker worker = new();
        int testAge = 60;
        worker.Age = testAge;
        Assert.That(worker.Age, Is.EqualTo(testAge));
    }
    [Test]
    public void PositionTest()
    {
        Worker worker = new();
        string testPosition = "CEO of Bitcoin";
        worker.Position = testPosition;
        Assert.That(worker.Position, Is.EqualTo(testPosition));
    }
    [Test]
    public void SalaryTest()
    {
        Worker worker = new();
        int testSalary = 60;
        worker.Salary = testSalary;
        Assert.That(worker.Salary, Is.EqualTo(testSalary));
    }
}