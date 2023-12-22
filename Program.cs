using System.Numerics;

namespace ConsoleApp5._3._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуй, Мир!");

            Console.WriteLine("Здравствуй, Мир!");
            

            var someName = "Евгения";
            Console.WriteLine(someName);

            GetName(someName);

            Console.WriteLine(someName);

            //static void GetName(string name)
            //{
             //   Console.WriteLine("Введите ваше имя");
            //    name = Console.ReadLine();
            //}

            
        }
        static void GetName(string name)
        {
            Console.WriteLine("Введите ваше имя");
            name = Console.ReadLine();
        }

    }
}