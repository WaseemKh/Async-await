
using System;
using System.Threading.Tasks;

public class Program
{
	 public static  void  Main()
	{
		LongProcess();
		ShortProcess();

		Console.ReadKey();
	}

    public static async void LongProcess()
    {
        Console.WriteLine("Long Process Started....");
         await Task.Delay(3000);
        Console.WriteLine("3 second Later");
        Console.WriteLine("End Long Process !");
    }
    static void ShortProcess()
    {
        Console.WriteLine("Start SHORT Process ----");
        Console.WriteLine("END SHORT Process ----");

    }
}











