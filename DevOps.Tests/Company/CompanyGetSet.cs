using DevOps.Interfaces;
using DevOps.Classes;
using NUnit.Framework.Internal;
namespace DevOps.Tests;

public class GetSetTest
{
    [Test]
    public void NameTest()
    {
        Company company = new();
        string testName = "Test1";
        company.Name = testName;
        Assert.Equals(company.Name, testName);
    }
    [Test]
    public void DescriptionTest()
    {
        Company company = new();
        string testDescription = "Test1";
        company.Description = testDescription;
        Assert.Equals(company.Description, testDescription);
    }
}
