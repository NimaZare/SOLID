namespace S.Tools;

public class FileLogger
{
    public static void Log(string message)
    {
        File.WriteAllText(@"D:\Errors.txt", message);
    }
}
