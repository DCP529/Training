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
            Thread thread1 = new Thread(new ThreadStart(NewMethod));
            thread1.Start();

            MethodAsync();

            Console.ReadLine();
        }


        static bool SaveFile(string path)
        {
            var rnd = new Random();
            var text = "";

            for (int i = 0; i < 100_000; i++)
            {
                text += rnd.Next();
            }

            using(StreamWriter sw = new StreamWriter("", false, Encoding.ASCII))
            {
                sw.WriteLine();
            }

            return true;
        }

        static void NewMethod()
        {
            int j = 90;

            for (int i = 0; i < 15; i++)
            {
                j--;
                Console.WriteLine(j);
            }
        }

        static async Task MethodAsync()
        {
            await Task.Run(() => NewMethod());
            Console.WriteLine("It's so fucking deep");
        }
    }
}
