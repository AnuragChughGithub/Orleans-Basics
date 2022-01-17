namespace OrleansBasics.Client.Helpers;

public static class ConsoleHelpers
{
    public static void LineSeparator()
    {
        Console.WriteLine($"{Environment.NewLine}-----{Environment.NewLine}");
    }

    public static void ReturnToMenu()
    {
        LineSeparator();
        Console.WriteLine("Press any key to return to menu");
        Console.ReadKey();
        Console.Clear();
    }
}
