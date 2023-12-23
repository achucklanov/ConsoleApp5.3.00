using System.Numerics;

namespace ConsoleApp5._3._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуй, Мир!");


            var someName = "Евгения";
            Console.WriteLine(someName);

            GetName(ref someName);

            Console.WriteLine(someName);

            //static void GetName(string name)
            //{
             //   Console.WriteLine("Введите ваше имя");
            //    name = Console.ReadLine();
            //}

            
        }
        static string GetName(ref string name)
        {
            Console.WriteLine("Введите ваше имя");
            name = Console.ReadLine();
            return name;
        }

    }
}