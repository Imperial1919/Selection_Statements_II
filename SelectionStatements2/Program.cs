using System;

namespace SelectionStatements2
{
    class Program
    {
        static void Main(string[] args)
        {

            //init statement
            var r = new Random();
            var favNumber = r.Next(1/1000);


            var userinput = int.Parse(Console.ReadLine());


            if (favNumber > userinput)
            {
                Console.WriteLine("Too Low Amigo!");
            }

            else if(favNumber < userinput)
            {
                Console.WriteLine("That is WAY too high, try again!");
            }

            else
            {
                Console.WriteLine(" ..... Nevermind.");
            }

            Console.WriteLine("What was your favorite subject in High School?");
            var usersubject = Console.ReadLine();

            switch (usersubject) {
                case "History":
                    Console.WriteLine("Hey!, That was mine too! :D");
                    break;
                case "Math":
                    Console.WriteLine(".... ew... OH, ahem, I mean, COOOOOOL!");
                    break;
                case "Biology":
                    Console.WriteLine("I see.. I guess You are now in the medical field right?");
                    break;

                case "PE":
                    Console.WriteLine("Ah.. I see... yeah, i just slept duing that peirod honestly or drew stuff. :/");
                    break;

                case "Home Ed":
                    Console.WriteLine("Huh, I liked that class too actually. :) Only had it for one grade though. :/ I like to cook You see.");
                    break;


                default:
                    Console.WriteLine(".. The HELL did you just say?... I don't think my school had.. that class.");
                    break;
            
            }

            



        }
    }
}
