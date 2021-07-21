using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training
{

    class Program
    {
        public const int PROCENT = 1;
        static void Main(string[] args)
        {
            SalaryMonth(2_100_000, 60, 60_000, 40_000);
            Console.ReadLine();
        }

        public static void SalaryMonth(decimal sum, int amountMonth, decimal person1Salary, decimal person2Salary)
        {
            decimal salaryMonth = sum / amountMonth;

            for (decimal i = 0M; i < PROCENT; i+=0.01M)
            {
                decimal person1SalaryProcent = person1Salary * i;
                decimal person2SalaryProcent = person2Salary * i;

                decimal sumSalaryProcent = person1SalaryProcent + person2SalaryProcent;

                if (sumSalaryProcent == salaryMonth)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
