using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать экземпляр StreamReader для чтения из файла.
            StreamReader textReader = new StreamReader(@"C:\users\krist\documents\image.txt", true);
            // читать и отобразить строки из файла пока не достигнут конец файла
            string textReaderResult = textReader.ReadToEnd();
            //создание массива, который будет хранить разделенные пробелом цифры из файла
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            //создать массив типа byte длиной текстового массива -1
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            //приветси к байту каждую цифру в тестовом массиве, полученном из файла и присвоить это значение каждому члену массива imagebytes
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            ////освобождает все ресурсы, используемые объектом textReader (мне кажется это чем-то лишним)
            textReader.Dispose();
            //байты записываются в новый файл
            File.WriteAllBytes(@"C:\users\krist\documents\image.png", imageBytes);
        }
    }
}
