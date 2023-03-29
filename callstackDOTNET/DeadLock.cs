using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace callstackDOTNET
{
    internal class DeadLock
    {
        private object Obj1 = new object();
        private object Obj2 = new object();

        private void Lock1Lock2()
        {
            lock(Obj1)
            {
                System.Threading.Thread.Sleep(2000);
                lock(Obj2)
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Lock1Lock2 fonksiyonu tüm lockları aldı");
                }
            }
        }

        private void Lock2Lock1()
        {
            lock (Obj2)
            {
                System.Threading.Thread.Sleep(2000);
                lock (Obj1)
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Lock2Lock1 fonksiyonu tüm lockları aldı");
                }
            }
        }

        public void DeadLockaSebepOl()
        {
            Thread[] threads = new Thread[2];

            Console.WriteLine("DeadLockaSebepOl başladı");
            threads[0] = new Thread(new ThreadStart(Lock1Lock2));
            threads[1] = new Thread(new ThreadStart(Lock2Lock1));
            
            Console.WriteLine("DeadLockaSebepOl threadler yaratıldı");

            threads[0].Start();
            threads[1].Start();

            Console.WriteLine("DeadLockaSebepOl threadler başladı");

            threads[0].Join();
            threads[1].Join();

            Console.WriteLine("DeadLockaSebepOl threadler bitti");
        }


    }
}
