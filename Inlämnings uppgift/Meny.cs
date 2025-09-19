using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämnings_uppgift
{
    public class Meny
    {

        public static Player MainMeny()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Typewriter.WriteEach($"---Welcome to Blood red skies---");
            Console.ResetColor();
            Typewriter.WriteEach("Choose your name");
            string userName = Console.ReadLine().ToLower();

            bool invalidChoice = true;
            string className = "";

            while (invalidChoice)
            {


              Typewriter.WriteEach($"Welcome {userName} \nNow choose you breathing style. [Water] [Fire] [Wind]");

                Console.ForegroundColor = ConsoleColor.Blue;
                Typewriter.WriteEach($"\n----[Water Class Stats]---- \nMax Hp: 100 \nDamage: 15 \n---------------------------");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Typewriter.WriteEach($"\n----[Fire Class Stats]---- \nMax Hp: 80 \nDamage: 25 \n---------------------------");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Typewriter.WriteEach($"\n----[Wind Class Stats]---- \nMax Hp: 90 \nDamage: 20 \n---------------------------");
                Console.ResetColor();

                className = Console.ReadLine().ToLower();

                if (className == "water" || className == "fire" || className == "wind")
                {
                    invalidChoice = false;
                }
                else
                {

                    Console.WriteLine("Invalid choice. Please try again");

                }



            }

              return new Player(className, userName);





        }






        public static string AdventureMeny(Player player)
        {
           Typewriter.WriteEach($"\nNow choose what you will do. \n1.Mission 2.Rest 3.Status 4. Quit");
            string choice = Console.ReadLine();
            Console.Clear();

            while(true)
            {
                // Om svaret är giltig (dvs 1-4), skicka tillbaka ett svar
                // Annars, visa felmeddelande
                switch (choice)
                {
                    case "1":
                        
                        return "1";
                        

                    case "2":
                       
                        return "2";
                        

                    case "3":
                       
                        return "3";
                        

                    case "4":

                        return "4";
                        

                    default:
                        Console.WriteLine("1.Mission 2.Rest 3.Status 4. Quit");
                        Console.WriteLine("Invalid input, enter again");
                        choice = Console.ReadLine();
                        Console.Clear();
                        break;

                }
            }




            // returna ett svar
        }


        public static string ContinueMeny(Player player)
        {

            Typewriter.WriteEach("Now choose what you will do 1.Continue 2.Rest 3.Status 4.Quit");
            string choice = Console.ReadLine();
            Console.Clear();


            while (true)
            {
                switch (choice)
                {

                    case "1":
                        return "1";

                    case "2":
                        return "2";

                    case "3":
                        return "3";

                    case "4":
                        return "4";

                    default:
                        Console.WriteLine("1.Continue 2.Rest 3.Status 4.Quit");
                        Console.WriteLine("Invalid input, enter again");
                        choice = Console.ReadLine();
                        Console.Clear();
                        break;


                }
            }

                    

        }
    }
}
