Settings.AddSetting("Уровень громкости", "12");
Settings.AddSetting("Настройки графики", "Качество");
Settings.AddSetting("Разрешение", "1920х1080");
Settings.AddSetting("Цвет фона", "тёмно-серый");

Console.WriteLine(Settings.GetSettings());

Settings.RemoveSetting("Цвет фона");

Console.WriteLine(Settings.GetSettings());