using System.Text;

class Settings
{
    private static readonly Settings _instance = new();
    private static Dictionary<string, string> _settings = new();

    public Settings() { }

    public static Settings GetSettings()
        => _instance;

    public static void AddSetting(string settingName, string value)
    { 
        if (settingName == string.Empty)
            return;

        if (_settings.ContainsKey(settingName))
            _settings[settingName] = value;
        else
            _settings.Add(settingName, value);
    }

    public static void RemoveSetting(string settingName) 
        => _settings.Remove(settingName);

    public override string ToString()
    {
        StringBuilder builder = new();

        foreach (var key in _settings.Keys)
            builder.Append(int.TryParse(_settings[key], out int value)
                ? $"\"{key}\" - {value}\n"
                : $"\"{key}\" - \"{_settings[key]}\"\n");
        return builder.ToString();
    }
}