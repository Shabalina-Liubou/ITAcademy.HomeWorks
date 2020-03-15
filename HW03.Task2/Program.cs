using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 1;
            Byte b2 = 2;
            Console.WriteLine(b1.GetType());
            Console.WriteLine(b2.GetType());

            sbyte sb1 = 12;
            SByte sb2 = 13;
            Console.WriteLine(sb1.GetType());
            Console.WriteLine(sb2.GetType());

            short s1 = 20;
            Int16 s2 = 21;
            Console.WriteLine(s1.GetType());
            Console.WriteLine(s2.GetType());

            int value1 = 10;
            Int32 value2 = 11;
            Console.WriteLine(value1.GetType());
            Console.WriteLine(value2.GetType());

            long long1 = 1000;
            Int64 long2 = 1001;
            Console.WriteLine(long1.GetType());
            Console.WriteLine(long2.GetType());

            uint ui1 = 0;
            UInt32 ui2 = 1;
            Console.WriteLine(ui1.GetType());
            Console.WriteLine(ui2.GetType());

            ushort us1 = 0;
            UInt16 us2 = 2;
            Console.WriteLine(us1.GetType());
            Console.WriteLine(us2.GetType());

            char ch1 = 'a';
            Char ch2 = 'A';
            Console.WriteLine(ch1.GetType());
            Console.WriteLine(ch2.GetType());

            ulong ulong1 = 1000;
            UInt64 ulong2 = 1001;
            Console.WriteLine(ulong1.GetType());
            Console.WriteLine(ulong2.GetType());

            float fl1 = 1.1F;
            Single fl2 = 1.2F;
            Console.WriteLine(fl1.GetType());
            Console.WriteLine(fl2.GetType());

            double db1 = 3.14;
            Double db2 = 3.1453;
            Console.WriteLine(db1.GetType());
            Console.WriteLine(db2.GetType());

            decimal dc1 = 2.3M;
            Decimal dc2 = 4.566M;
            Console.WriteLine(dc1.GetType());
            Console.WriteLine(dc2.GetType());

            Console.ReadLine();
        }
    }
}
