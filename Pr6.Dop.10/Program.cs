using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = 6, result; // присвоение локальной переменной n целого типа "byte"

            // Умножить на 2
            result = (byte)(n << 1); // 
            Console.WriteLine("{0} * 2 = {1}", n, result); //вывод строки "..." с указанными данными на экран.

            // Умножить на 4
            result = (byte)(n << 2);
            Console.WriteLine("{0} * 4 = {1}", n, result); //вывод строки "..." с указанными данными на экран.

            // Разделить на 2
            result = (byte)(n >> 1);
            Console.WriteLine("{0} / 2 = {1}", n, result); //вывод строки "..." с указанными данными на экран.

            Console.ReadLine(); //чтение данных.
        }
    }
}
