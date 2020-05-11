using System;

namespace Band
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Type a message and the press 'Enter'");
            var message = System.Console.ReadLine();
            Console.WriteLine( "Hello!! you said " + message);
        }
    }
}
