// Проверяем, установлен ли питончик
public static bool IsSoftwareInstalled(string name)
{
    bool result = false;

    CheckRegistry(@"SOFTWARE\Python");
    if (!result) CheckRegistry(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall");

    void CheckRegistry(string path)
    {
        using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path))
        {
            if (key == null) return;
            foreach (var subkey_name in key.GetSubKeyNames())
            {
                using (var subkey = key.OpenSubKey(subkey_name))
                {
                    if (subkey != null && subkey.GetValue("DisplayName")?.ToString() == name)
                    {
                        result = true;
                        break;
                    }
                }
            }
        }

        return result
}
    if result == true:
{
    Console.WriteLine("Установлен");
}
else
{
    Console.WriteLine("Не установлен");
}