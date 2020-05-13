using System;

namespace Band
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("What is the name of your band");
            // string name = System.Console.ReadLine();
            // Console.WriteLine("How many people are in the band?");
            // int numberOfMembers = int.Parse(System.Console.ReadLine());
            // System.Console.WriteLine($"{name} has {numberOfMembers}");

            Console.WriteLine("What is the name of your band");
            string name = Console.ReadLine();
            Console.WriteLine("How many people are in the band?");
            int numberOfMembers = 0;
            if (!int.TryParse(Console.ReadLine(), out numberOfMembers))
            {
                Console.WriteLine("Input was invalid");
                Environment.Exit(0);
            }
            else if (numberOfMembers <= 0)
            {
                Console.WriteLine("You must have atleast 1 member");
                Environment.Exit(0);
            };
            System.Console.WriteLine($"{name} has {numberOfMembers}");
        }
    }
}
