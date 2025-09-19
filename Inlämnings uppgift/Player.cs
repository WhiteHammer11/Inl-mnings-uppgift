using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Inlämnings_uppgift
{
    public class Player
    {
        public string ClassName { get; set; } = string.Empty; // "water" | "fire" | "wind"
        public string UserName { get; set; } = string.Empty;

        public int MaxHp { get; set; }
        public int Hp { get; set; }
        public int Damage { get; set; }
        public int Gold { get; set; }
        public int HpRegeneration { get;  set; }

        public Player(string className, string userName)
        {
            // Säkra indata
            className = (className ?? "").ToLower();
            userName = userName ?? "";

            ClassName = className;
            UserName = userName;

            // Grundvärden
            Gold = 0;
            HpRegeneration = 15;

            // Stats per klass
            switch (className)
            {
                case "water":
                    MaxHp = 100;
                    Damage = 15;
                    break;

                case "fire":
                    MaxHp = 80;
                    Damage = 25;
                    break;

                case "wind":
                    MaxHp = 90;
                    Damage = 20;
                    break;

                default:
                    
                    MaxHp = 120;
                    Damage = 15;
                    ClassName = "water";
                    break;
            }

            Hp = MaxHp;
        }

      

        public void Heal()
        {
            int before = Hp;
            Hp = Math.Min(MaxHp, Hp + 5);
            Typewriter.WriteEach($"You have gained back 5 hp. Current hp: {Hp}");
        }

        public void Introduce()
        {
            Typewriter.WriteEach($"Welcome {UserName}, Master of the {ClassName} breathing style \nGood luck on your journey");
        }

        public void Stats()
        {
            var (color, label) = ClassName switch
            {
                "fire" => (ConsoleColor.Red, "Fire"),
                "water" => (ConsoleColor.Blue, "Water"),
                "wind" => (ConsoleColor.Green, "Wind"),
                _ => (ConsoleColor.White, ClassName)
            };

            Console.ForegroundColor = color;
            Typewriter.WriteEach(
                $"-----Hero-----" +
                $"\nName: {UserName}" +
                $"\nBreathing style: {label}" +
                $"\nHp: {Hp}/{MaxHp}" +
                $"\nDamage: {Damage}" +
                $"\nGold: {Gold}" +
                $"\n--------------"
            );
            Console.ResetColor();
        }

        public void Rest()
        {
            if (Hp < MaxHp)
            {
                Hp = MaxHp;
                Console.WriteLine($"This rest restored you hp, Your hp now is {Hp}");
            }
            else
            {
                Console.WriteLine("You are already at max hp");
            }
        }
    }
}
