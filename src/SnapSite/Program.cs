using System.Text.Json;
using SnapSite.Models;

namespace SnapSite;

class Program
{
    static void Main(string[] args)
    {
        Options? options = SimpleParseOptions(args);
        if (options == null)
        {
            Console.WriteLine("Invalid options");
            return;
        }

        

        Console.WriteLine("Hello there!");
    }

    // temp method to parse options from a file
    public static Options? SimpleParseOptions(string[] args)
    {
        if (args.Length != 1)
            return null;

        if (!File.Exists(args[0]))
            return null;

        return JsonSerializer.Deserialize<Options>(File.ReadAllText(args[0]));
    }
}