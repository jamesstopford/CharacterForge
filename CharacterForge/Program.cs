using System;

namespace CharacterForge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            var person = new Actor();

            Console.WriteLine("Person's name is {0} and their GUID is {1}", person.GetName(), person.GetGuid().ToString());

        }
    }
}
