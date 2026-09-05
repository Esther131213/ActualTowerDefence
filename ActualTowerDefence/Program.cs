using System;
using System.IO;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        try
        {
            using var game = new ActualTowerDefence.Game1();
            game.Run();
        }
        catch (Exception ex)
        {
            var msg = $"Unhandled exception: {ex}\n";
            Console.Error.WriteLine(msg);
            try { File.WriteAllText("crash.log", msg); } catch { }
            throw;
        }
    }
}
