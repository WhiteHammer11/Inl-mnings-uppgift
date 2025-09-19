using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Inlämnings_uppgift;

public class Mission
{
    public static void MissionTime(Player player)
    {


        Typewriter.WriteEach($" Master Kagaya: Thank you for accepting the mission {player.UserName}. " + $"\nYour mastery of the breathing {player.ClassName} style is perfectly suited for the mission ahead.");



        TextColor.TypeColored(player, $"\n{player.UserName}: I am ready Master. What are your orders.");

        Typewriter.WriteEach($"\nMaster Kagaya: I have gotten word that an upper moon has kidnapped a young girl \nwe must act quickly before it's too late.");

        Typewriter.WriteEach($"\nMaster Kagaya: Although I do not know which upper moon it is \nit will still be a dangerous mission considering their strength.");

        TextColor.TypeColored(player, $"\n{player.UserName}: I don't care which one of the upper moons it is. I'll take him down at any cost.");

        Typewriter.WriteEach($"\nMaster Kagaya: I know you don't, but make sure to be careful as we don't really know how many of them are there.");

        TextColor.TypeColored(player, $"\n{player.UserName}: Doesn't matter if there are more than one, I'll take them all on.");

        Typewriter.WriteEach($"\nMaster Kagaya: Fearless as always.");

        TextColor.TypeColored(player, $"\n{player.UserName}: Do not worry Master. I promise I will bring the girl back safe and sound even if it costs me my life.");

        Typewriter.WriteEach($"\nMaster Kagaya: I know you will, {player.UserName}.");
        Console.WriteLine();
        Console.WriteLine("Press any key to continye");

        Console.ReadKey();
        Console.Clear();

        
        Random random = new Random();
        bool chooseAkaza = random.Next(2) == 0;
        Enemy firstEnemy = chooseAkaza ? new Enemy("Akaza") : new Enemy("Douma");
        Enemy secondEnemy = chooseAkaza ? new Enemy("Douma") : new Enemy("Akaza");

        Typewriter.WriteEach("You start you path in the dark forest where Master Kagaya had gotten word that the demon was last seen.\nYou hear a strange sound and turn around");
        Console.WriteLine();


        bool between = true;

        while (between)
        {
            string answer = Meny.ContinueMeny(player);

            switch (answer)
            {
                case "1":
                    between = false;
                    break;

                case "2":
                    player.Rest();
                    break;

                case "3":
                    player.Stats();
                    break;

                case "4":
                    Typewriter.WriteEach("You abandoned the mission...Coward...");
                    Environment.Exit(0);
                    break;

            }
        }

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
        
        Battle.StartFight(player, firstEnemy);

       
        Typewriter.WriteEach($"\nAfter the fight with {firstEnemy.Name}, you keep walking down the dark path...");
        Typewriter.WriteEach("The air grows colder, and soon you reach the entrance to a hidden cave where Master Kagaya believes the girl is held.");
        Console.WriteLine("\nPress any key to enter the cave...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine();

        bool between2 = true;

        while (between2)
        {
            string answer = Meny.ContinueMeny(player);

            switch (answer)
            {
                case "1":
                    between2 = false;
                    break;

                case "2":
                    player.Rest();
                    break;

                case "3":
                    player.Stats();
                    break;

                case "4":
                    Typewriter.WriteEach("You abandoned the mission...Coward...");
                    Environment.Exit(0);
                    break;

            }
        }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();



            Battle.StartFight(player, secondEnemy);


            Typewriter.WriteEach($"\nExhausted but determined after defeating {secondEnemy.Name}, you sense an even stronger presence deeper in the cave...");
            Console.WriteLine("\nPress any key to face the final challenge...");
            Console.ReadKey();
            Console.Clear();


        bool between3 = true;

        while (between3)
        {
            string answer = Meny.ContinueMeny(player);

            switch (answer)
            {
                case "1":
                    between3 = false;
                    break;

                case "2":
                    player.Rest();
                    break;

                case "3":
                    player.Stats();
                    break;

                case "4":
                    Typewriter.WriteEach("You abandoned the mission...Coward...");
                    Environment.Exit(0);
                    break;

            }
        }

        Enemy finalBoss = new Enemy("Kokushibo");
            Battle.StartFight(player, finalBoss);


            Typewriter.WriteEach("\nWith Kokushibo defeated, you rescue the kidnapped girl and complete your mission!");


        Typewriter.WriteEach($"Thank you for playing blood red skies \nYou have succefuly completed the mission given to you by Master Kagaya");
        Typewriter.WriteEach($"\nBut your story will not end here {player.UserName} \nThe next part of blood red skies will shortly be realesed and it will be a battle of life and death against the demon king");
        Typewriter.WriteEach($"\nIf you want to replay the mission with your new stats press any key to continue and go back to the mission");
        Console.ReadKey();
        Console.Clear();

        

    }

 }























































