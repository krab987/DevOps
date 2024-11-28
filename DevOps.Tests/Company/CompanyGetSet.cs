using DevOps.Classes;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;
namespace DevOps.Tests;

public class GetSetTest
{
    [Test]
    public void NameTest()
    {
        Company company = new();
        string testName = "Test1";
        company.Name = testName;
        ClassicAssert.AreEqual(company.Name, testName);
    }
    [Test]
    public void DescriptionTest()
    {
        Company company = new();
        string testDescription = "Test1";
        company.Description = testDescription;
        ClassicAssert.AreEqual(company.Description, testDescription);
    }
}
