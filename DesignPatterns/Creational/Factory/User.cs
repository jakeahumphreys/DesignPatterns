namespace DesignPatterns.Creational.Factory;

public abstract class User
{
    private readonly List<Permission> _permissions = new List<Permission>();

    public User()
    {
        SetPermissions();
    }

    public List<Permission> Permissions => _permissions;

    public abstract void SetPermissions();
}