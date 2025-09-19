using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



      using System;
      using System.Collections.Generic;

namespace Inlämnings_uppgift
    {
        public class Battle
        {
        

        public static void StartFight(Player player, Enemy enemy)
            {
            Typewriter.WriteEach($"{enemy.Name} appears before you!");

                bool healNext = false;

                bool parryNext = false;

                bool ultimatedUsed = false;

                while (player.Hp > 0 && enemy.Hp > 0)
                {
                    Typewriter.WriteEach(
                        $"\nYour HP: {player.Hp}/{player.MaxHp} | Damage: {player.Damage}" +
                        $"\n{enemy.Name}'s HP: {enemy.Hp}/{enemy.MaxHp} | Damage: {enemy.EnemyDamage}"
                    );

                if (enemy.Name == "Kokushibo" && !ultimatedUsed)
                {

                    Typewriter.WriteEach("\nChoose your action: [1] Attack  [2] Heal  [3] Parry  [4] Ultimate");
                }
                else
                {

                    Typewriter.WriteEach("\nChoose your action: [1] Attack  [2] Heal  [3] Parry");


                }

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            enemy.Hp -= player.Damage;
                            Typewriter.WriteEach($"You attack {enemy.Name} for {player.Damage} damage!");
                            Typewriter.WriteEach($"{enemy.Name}'s current HP: {enemy.Hp}/{enemy.MaxHp}");
                            Console.WriteLine("press any key to continue");
                            Console.ReadKey();
                             Console.Clear();
                            break;

                        case "2":
                        healNext = true;
                            player.Heal();
                            Typewriter.WriteEach($"Your HP: {player.Hp}/{player.MaxHp}");
                             Console.WriteLine("press any key to continue");
                             Console.ReadKey();
                             Console.Clear();
                            break;

                        case "3":
                            parryNext = true;
                            Typewriter.WriteEach("You prepare to dodge the next attack!");
                              Console.WriteLine("press any key to continue");
                              Console.ReadKey();
                               Console.Clear();
                        break;


                        case "4":
                            if (enemy.Name == "Kokushibo" && !ultimatedUsed)
                            {
                            int ultimateDamage = 50;
                            enemy.Hp -= ultimateDamage;
                            ultimatedUsed = true;
                            TextColor.TypeColored(player, $"{player.ClassName} breathing style, 13th form, ultimate release");
                            Typewriter.WriteEach($"\nYour ultimate did {ultimateDamage} damage on {enemy.Name}\n{enemy.Name} current stats:{enemy.Hp}/{enemy.MaxHp}");
                            }
                        else
                        {
                            Typewriter.WriteEach("You cannot use that move anymore");
                        }
                        break;


                            default:
                            Typewriter.WriteEach("Invalid choice, you lost your turn!");
                            break;
                    }




                    if (enemy.Hp <= 0) break;

                    if (parryNext)
                    {
                        Typewriter.WriteEach($"{enemy.Name} attacks, but you dodged it and manged to counter! \n Damaging {enemy.Name} for 5 Hp");
                         enemy.Hp -= 5;
                         Typewriter.WriteEach($"Enemys current hp:{enemy.Hp}");
                         Console.WriteLine("press any key to continue");
                         Console.ReadKey();
                         Console.Clear();
                          parryNext = false;
                    }
                    else if (healNext)
                    {
                       Typewriter.WriteEach($"{enemy.Name} tried to attack you while you were healing but you maneged to block it");
                       Console.WriteLine("press any key to continue");
                       Console.ReadKey();
                       Console.Clear();
                       healNext = false;
                    }
                    else
                    {
                       player.Hp -= enemy.EnemyDamage;
                       Typewriter.WriteEach($"{enemy.Name} attacks you for {enemy.EnemyDamage} damage!");
                       Typewriter.WriteEach($"Your current HP: {player.Hp}/{player.MaxHp}");

                       Console.WriteLine("press any key to continue");
                       Console.ReadKey();
                       Console.Clear();


                    }
                }

                if (player.Hp <= 0)
                {
                    Typewriter.WriteEach("\nYou were defeated... Game Over!");
                    Environment.Exit(0);
                }
                else
                {
                    Typewriter.WriteEach($"\nYou defeated {enemy.Name}!");
                    player.Gold += enemy.EvilGold;
                   

                    player.Damage += 5;
                    Typewriter.WriteEach($"You gained {enemy.EvilGold} gold.");
                    Typewriter.WriteEach($"\n You have gotten +5 in damage. New damage:{player.Damage}");
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
            }
            }
        }
    } 
