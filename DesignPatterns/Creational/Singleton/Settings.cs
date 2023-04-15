namespace DesignPatterns.Creational.Singleton;

public class Settings
{
    static Settings instance; 
    static Dictionary<string, string> Configs = new Dictionary<string, string>();

    protected Settings()
    {
        Configs.Add("EnableConfig", "True");
        Configs.Add("SecondExampleConfig", "True");
    }

    public static Settings GetSettings()
    {
        if (instance == null)
            instance = new Settings();

        return instance;
    }
}