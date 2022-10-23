
using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        Task<long> num1 = LongProcess();

       // Task<long> num2 = ShortProcess();

        var total = await num1 + 3;
        Console.WriteLine($"Total is :"+ total);
        Console.ReadKey();
    }

    public static  async Task<long> LongProcess()
    {
        List<int> list = new List<int>();
     
        for (var i = 0; i <= 10; i++)
        {

            list.Add(i);
        }

        //get total for it 

        long total = 0;
        list.ForEach(i =>
        {
            total += i;
        });
        return total;

        //can use this (n*n+1) /2 however i want use async and await just
    }
   
}











