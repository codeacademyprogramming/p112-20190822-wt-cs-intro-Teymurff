using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account();
            Console.WriteLine("***HESABIN YARADILMASI***");
            Console.WriteLine("Adinizi daxil edin");
            ac.Name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin");
            ac.Surname = Console.ReadLine();
            Console.WriteLine("Shexsiyyet vesiqesinin nomresini daxil edin");
            ac.IDNumber = int.Parse(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("\n============================================\n");
            Console.ReadLine();
            Console.WriteLine("1 - Balansa bax");
            Console.WriteLine("2 - Balans artir");
            Console.WriteLine("3 - Balansdan chixarish");
            Console.WriteLine("4 - Hesab melumatlarini deyish");
            Console.WriteLine("0 - Chixish");
            Console.WriteLine("\n============================================\n");
      

            int x = Convert.ToInt32(Console.ReadLine());
            double a = ac.Balance;
            switch (x)
      
            {

                case 1:
                    a = 0;
                    Console.WriteLine("Sizin balansiniz:" + a);
                    break;

                case 2:
                    Console.WriteLine("Balansi artirmaq uchun meblegi daxil edin:");
                    double b = double.Parse(Console.ReadLine());
                     a= a + b;
                    Console.WriteLine("Sizin balansiniz:" + a);
                    break;

                case 3:
                    Console.WriteLine("Balansi azaltmaq uchun meblegi daxil edin:");
                    double d = double.Parse(Console.ReadLine());
                    a = a - d;
                    Console.WriteLine("Sizin balansiniz:" + a);
                    break;
           
                case 4:


                    break;

                case 0:


                    break;

                default:


                    break;
            }
            Console.ReadLine();
        }
    }
}
