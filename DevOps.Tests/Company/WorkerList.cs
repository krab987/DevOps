namespace DevOps.Tests;
using DevOps.Classes;
using NUnit.Framework.Legacy;

public class WorkerListTest
{
    [Test]
    public void WorkerListTest1()
    {
        Company company = new();
        Worker worker1 = new();
        company.HireWorker(worker1);
        ClassicAssert.AreEqual(worker1, company.Workers.ElementAt(0));
    }
    [Test]
    public void WorkerListTest2()
    {
        Company company = new();
        Worker worker1 = new();
        Worker worker2 = new();
        company.HireWorker(worker1);
        company.HireWorker(worker2);
        ClassicAssert.AreEqual(worker1, company.Workers.ElementAt(0));
    }
    [Test]
    public void WorkerListTest3()
    {
        Company company = new();
        Worker worker1 = new();
        Worker worker2 = new();
        company.HireWorker(worker1);
        company.HireWorker(worker2);
        ClassicAssert.AreEqual(worker2, company.Workers.ElementAt(1));
    }
    [Test]
    public void WorkerListTest4()
    {
        Company company = new();
        Worker worker1 = new();
        Worker worker2 = new();
        company.HireWorker(worker1);
        company.HireWorker(worker2);
        _ = company.FireWorkerAt(0); // I assume ID is their number in the list.
        ClassicAssert.AreEqual(worker1.Id, company.Workers.ElementAt(0).Id);
    }
}