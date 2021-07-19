using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        public static object locker = new object();

        static void Main(string[] args)
        {
            //Thread thread1 = new Thread(new ThreadStart(NewMethod));
            //thread1.Start();

            //MethodAsync();


            var result = SaveFileAsync("text.txt");
            var input = Console.ReadLine();

            Console.WriteLine(result.Result);
            Console.ReadLine();

        }


        static async Task<bool> SaveFileAsync(string path)
        {
            var result = await Task.Run(() => SaveFile(path));

            return result;

        }

        static bool SaveFile(string path)
        {
            var rnd = new Random();
            var text = "";

            for (int i = 0; i < 50000; i++)
            {
                text += rnd.Next();
            }

            using (StreamWriter sw = new StreamWriter(path, false, Encoding.ASCII))
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
