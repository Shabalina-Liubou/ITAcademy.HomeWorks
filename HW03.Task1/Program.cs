using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 примера неявного приведения типов

            byte valueByte = 5;
            ushort valueUshort = valueByte;

            int valueInt1 = 10;
            long valueLong1 = valueInt1;

            float valueFloat = 3.14F;
            double valueDouble = valueFloat;

            // 3 примера явного приведения типов

            long valueLong = 1000;
            int valueInt = (int)valueLong;

            ushort a = 7;
            byte b = (byte)a;

            double valueDouble1 = 110.15;
            decimal valueDec = (decimal)valueDouble1;

            // 3 примера операции упаковки

            int firstValueToBox = 10;
            object boxedItem1 = firstValueToBox;

            bool secondValueToBox = true;
            object boxedItem2 = secondValueToBox;

            char thirdValueToBox = 'A';
            object boxedItem3 = thirdValueToBox;

            // 3 примера операции распаковки

            ushort valueToUnbox1 = (ushort)(int)boxedItem1;

            // Невозможны никакие преобразования из bool в числовые типы и обратно
            // Согласно справочнику Дж. Албахари

            int valueToUnbox3 = (char)boxedItem3;

        }
    }
}
