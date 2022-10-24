
using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        longProcess();
        Console.ReadKey();
    }

    public static async Task data()
    {
        Thread.Sleep(5000);
        Console.WriteLine("Data Completed");

    }

    public static async void longProcess()
    {
        Task.Run(() => data());
        Console.WriteLine("Data Still Calling");
        //return
    }

}











