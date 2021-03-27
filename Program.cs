using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Math;
using static System.Console;

namespace pract6_1zadanie__5_
{
    class Program
    {
        static void Main()
        {
            try
            {
                var rand = new Random();
                var f = new FileStream("text.txt", FileMode.Create, FileAccess.ReadWrite);
                var n = new byte[10];
                WriteLine("\n\t\t\tЗапись в файл");
                for (int i = 0; i < 10; i++)
                {
                    n[i] = (byte)(rand.Next(0, 255));
                    WriteLine(n[i]);
                }
                WriteLine("\n\n\t\t\tЧтение из файла");
                f.Write(n, 0, 10);
                f.Seek(0, SeekOrigin.Begin);
                var g = new byte[f.Length];
                double k = 1;
                for (int i = 0; i < f.Length; i++)
                {
                    g[i] = (byte)f.ReadByte();
                    k *= g[i];
                    WriteLine(g[i]);
                }
                WriteLine($"\n\nПроизведение чисел в файле равно: {k}");
                f.Close();
                ReadKey();
            }
            catch 
            {
                WriteLine("Произошла ошибочка");
            }
            ReadKey();
        }
    }
}
