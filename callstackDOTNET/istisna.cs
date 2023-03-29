using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace callstackDOTNET
{
    internal class istisna
    {
        public istisna() { }

        public int sifirabol(int a, int b)
        {
            //if (b == 0)
            //{
            //    Console.WriteLine("Payda sıfır olamaz!!!");
            //    return -1;
            //}
            return a / b;
        }
        [HandleProcessCorruptedStateExceptions]
        public int sifiraboltrycatch(int a, int b)
        {
            int c = 0;

            try
            {
                c = (int)(a / b);
            }
            catch 
            {

                //Console.WriteLine($"exception oluştu: {ex.Message}");
                // Loglama yapılabilir
                throw;
            }

            return c;
        }
    }
}
