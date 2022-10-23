
using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        Task<int> result = LongProcess();
        ShortProcess();
        var val = await result; //wait until return value
        Console.WriteLine("result" + val);

       
        Console.ReadKey();
    }

    public static async Task<int> LongProcess()
    {
        Console.WriteLine("Long Process Started....");
        await Task.Delay(5000);
        Console.WriteLine("3 second Later");
        return 10;
    }
    static void ShortProcess()
    {
        Console.WriteLine("Start SHORT Process ----");
        Console.WriteLine("END SHORT Process ----");

    }
}











