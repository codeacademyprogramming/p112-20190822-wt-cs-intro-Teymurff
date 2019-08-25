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
            double a = ac.Balance;
            double i = ac.BalanceIncrement;
            double d = ac.BalanceDecrement;
            string name = ac.Name;
            string surname = ac.Surname;
            string id = ac.IDNumber;
            string newName = ac.Name;
            string newSurname = ac.Surname;
            string newId = ac.IDNumber;
            Console.WriteLine("***HESABIN YARADILMASI***");
            Console.WriteLine("Adinizi daxil edin:");
            name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin:");
            surname = Console.ReadLine();
            Console.WriteLine("Shexsiyyet vesiqesinin nomresini daxil edin:");
            id = Console.ReadLine();



            while (true)
            {
                Console.WriteLine("1 - Balansa bax");
                Console.WriteLine("2 - Balans artir");
                Console.WriteLine("3 - Balansdan chixarish");
                Console.WriteLine("4 - Hesab melumatlarini deyish");
                Console.WriteLine("0 - Chixish");
                Console.WriteLine("-------------------------------------------\n\n");
                int x = int.Parse(Console.ReadLine());
                switch (x)

                {

                    case 1:
                        a = 0;
                        Console.WriteLine("Sizin balansiniz:" + a);
                        break;

                    case 2:
                        Console.WriteLine("Balansi artirmaq uchun meblegi daxil edin:");
                        i = double.Parse(Console.ReadLine());
                        a = a + i;
                        Console.WriteLine("Sizin balansiniz:" + a);
                        break;

                    case 3:
                        Console.WriteLine("Balansi azaltmaq uchun meblegi daxil edin:");
                        d = double.Parse(Console.ReadLine());
                        if (d > a)
                        {
                            Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
                        }
                        else
                        {
                            a = a - d;
                            Console.WriteLine("Sizin balansiniz:" + a);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Adinizi daxil edin:");
                        newName = Console.ReadLine();
                        while (string.IsNullOrEmpty(newName))
                        {
                            Console.WriteLine("Ad bosh ola bilmez, adinizi bir daha daxil edin:");
                            newName = Console.ReadLine();
                        }
                        Console.WriteLine("Soyadinizi daxil edin:");
                        newSurname = Console.ReadLine();
                        while (string.IsNullOrEmpty(newSurname))
                        {
                            Console.WriteLine("Soyad bosh ola bilmez, soyadinizi bir daha daxil edin:");
                            newSurname = Console.ReadLine();
                        }
                        Console.WriteLine("Shexsiyyet vesiqesinin nomresini daxil edin:");
                        newId = Console.ReadLine();
                        while (string.IsNullOrEmpty(newId))
                        {
                            Console.WriteLine("SV nomresi bosh ola bilmez, SV nomresini bir daha daxil edin:");
                            newId = Console.ReadLine();
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("duzgun duymeni daxil edin");

                        break;
                }
            }
        }
    }
}
