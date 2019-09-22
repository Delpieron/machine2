using System;

namespace DrinkMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz co chcesz kupic");
            Console.WriteLine("s - Orange juice");
            Console.WriteLine("W - Water");
            Console.WriteLine("c- Cola");
            
            machine Machine = new machine();
            //Products products = new Products();

            var pr = Console.ReadKey();
            switch (pr.Key)
            {
                case ConsoleKey.S:
                    Console.WriteLine();
                    Console.WriteLine("Kupiles sok");
                    Machine.juice.Pop();
                    break;
                case ConsoleKey.W:
                    Console.WriteLine();
                    Console.WriteLine("kupiles wode");
                    Machine.water.Pop();
                    break;
                case ConsoleKey.C:
                    Console.WriteLine();

                    Console.WriteLine("kupiles cole");
                    Machine.cola.Pop();
                    break;
                default:
                    Console.WriteLine("podales zla litere");
                    break;
            }

            Console.Read();

        }
    }
}
