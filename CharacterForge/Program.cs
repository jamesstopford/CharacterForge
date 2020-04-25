using System;

namespace CharacterForge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var person = new Actor();

            Console.WriteLine("Person's name is {0}", person.GetName());

        }
    }
}
