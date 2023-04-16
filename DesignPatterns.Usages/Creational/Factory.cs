using System.Linq;
using DesignPatterns.Creational.Factory;
using NUnit.Framework;

namespace DesignPatterns.Usages.Creational;

[TestFixture]
public sealed class Factory
{
    private AdminUser _adminUser;
    private StandardUser _standardUser;

    [OneTimeSetUp]
    public void Setup()
    {
        _adminUser = new AdminUser();
        _standardUser = new StandardUser();
    }
    
    [Test]
    public void Then()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_adminUser.Permissions.Single(x => x.Key == "CanCreateTasks").Value, Is.True);
            Assert.That(_adminUser.Permissions.Single(x => x.Key == "CanDeleteTasksFromOthers").Value, Is.True);
            
            Assert.That(_standardUser.Permissions.Single(x => x.Key == "CanCreateTasks").Value, Is.True);
            Assert.That(_standardUser.Permissions.Single(x => x.Key == "CanDeleteTasksFromOthers").Value, Is.False);
        });
    }
}