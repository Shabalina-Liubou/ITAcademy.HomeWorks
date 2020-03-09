using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Чтение файла по пути "C:\Temp\image.txt"
            // 2. Создание массива, который будет хранить массив строк, считанный из файла и разбитый по на части по пробелам
            // 3. Создание массива байтов, где будут записаны байты, для воспроизведения фото
            // 4. В цикле каждая строка из массива в п.2 будет конвертироваться в бинарную версию и записываться в массив байтов
            // 5. Полученный массив байтов будет записан в файл по указанному пути "C:\Temp\image.png"
            // 6. Закрываем поток записи и освобождаем ресурсы.

            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);

            string textReaderResult = textReader.ReadToEnd();

            string[] arrayOfTextResult = textReaderResult.Split(' ');

            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);

            textReader.Dispose();
        }
    }
}
