using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class Logs
{
    [Conditional("DEBUG")]
    public static void Log(string message)
    {
        Debug.Log(message);
    }
}
