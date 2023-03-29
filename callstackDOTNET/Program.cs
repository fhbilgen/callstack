using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callstackDOTNET
{
    internal class Program
    {
        static int fonksiyon1(int r)
        {
            return fonksiyon2(r);
        }

        static int fonksiyon2(int q)
        {
            return 2 * fonksiyon3(q);
        }

        static int fonksiyon3(int z)
        {
            return 3 * fonksiyon4(z);
        }

        static int fonksiyon4(int y)
        {
            return 4 * fonksiyon5(y);
        }

        static int fonksiyon5(int x)
        {
            //DebugBreak();
            System.Diagnostics.Debugger.Break();
            return x * 5;
        }
        static void Main(string[] args)
        {
            //int i = 10;
            //int j = 0;
            //int z = 0;
            //DeadLock d = new DeadLock();


            Console.WriteLine("basla");
            Console.ReadLine();

            //j = fonksiyon1(i);
            //Console.WriteLine($"sonuç: {j}");

            //Console.WriteLine("Kisi olustur");
            //Console.ReadLine();

            //Kisi k = new Kisi(new DateTime(1980, 06, 30), true);
            //Console.WriteLine($"Kisi adı: {k.GetName()}");

            //Console.WriteLine("1. Kisi olustu");
            //Console.ReadLine();

            //Kisi k2 = new Kisi(new DateTime(1990, 09, 30), false);
            //Console.WriteLine($"Kisi adı: {k2.GetName()}");

            //d.DeadLockaSebepOl();

            istisna i = new istisna();

            //Console.WriteLine($"10/0 = {i.sifirabol(10, 0)}");
            int x = 0;

            try
            {
                x = i.sifiraboltrycatch(10, 0);
                Console.WriteLine($"10/0 = {x}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"exception oluştu: {ex.Message}");
            }
            
            
            


            Console.WriteLine("Cıkmak icin tusa basın");
            Console.ReadLine();
            
        }
    }
}
