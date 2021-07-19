using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
        }

        public static async Task<decimal> SalaryPaperAsync(int count, int cost)
        {
            var result = await Task.Run(() => SalaryPaper(count, cost));
            return result;
        }

        public static decimal SalaryPaper(int count, int cost)
        {
            double result;

            if (count >= 1000)
            {
                result = cost * 0.1;
            }
            else
            {
                result = cost * 0.05;
            }

            return (decimal)result;
        }





    //    static async Task<bool> SaveFileAsync(string path)
    //    {
    //        var result = await Task.Run(() => SaveFile(path));

    //        return result;

    //    }

    //    static bool SaveFile(string path)
    //    {
    //        var rnd = new Random();
    //        var text = "";

    //        for (int i = 0; i < 50000; i++)
    //        {
    //            text += rnd.Next();
    //        }

    //        using (StreamWriter sw = new StreamWriter(path, false, Encoding.ASCII))
    //        {
    //            sw.WriteLine();
    //        }

    //        return true;
    //    }

    //    static void NewMethod()
    //    {
    //        int j = 90;

    //        for (int i = 0; i < 15; i++)
    //        {
    //            j--;
    //            Console.WriteLine(j);
    //        }
    //    }

    //    static async Task MethodAsync()
    //    {
    //        await Task.Run(() => NewMethod());
    //        Console.WriteLine("It's so fucking deep");
    //    }
    }
}
