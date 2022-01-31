using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        //Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
        //Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.
        static void Main(string[] args)
        {
            Console.Write("Введите коэфициент b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэфициент k=");
            int k = Convert.ToInt32(Console.ReadLine());
            StructureEquation structureEquation = new StructureEquation(b, k);
            Console.Write("Решение уравнения равно {0}", structureEquation.Root());
            Console.ReadKey();
        }
    }
}
