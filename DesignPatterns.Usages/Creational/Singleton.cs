using DesignPatterns.Creational.Singleton;
using NUnit.Framework;

namespace DesignPatterns.Usages.Creational;

[TestFixture]
public class Singleton
{
    private Settings? _settingsOne;
    private Settings? _settingsTwo;

    [OneTimeSetUp]
    public void Setup()
    {
        _settingsOne = Settings.GetSettings();
        _settingsTwo = Settings.GetSettings();
    }

    [Test]
    public void Then()
    {
        Assert.That(_settingsTwo, Is.EqualTo(_settingsOne));
    }
}