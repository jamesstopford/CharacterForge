using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CharacterForge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var actors = new List<Actor>();


            var person = new Actor();

            int targetPartySize = 10;
            
            while (actors.Count < targetPartySize )
            {
                var partyGoer = new Actor();
                partyGoer.Randomize();
                actors.Add(partyGoer);

            }
            



            foreach (Actor actor in actors)
            {
                Console.WriteLine("Welcome to the party {0}. \nYour robot name is {1}", actor.GetName(), actor.GetGuid()) ;
                Console.WriteLine("******************************");
            }

            

        }
    }
}
