using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



 using System;

namespace Inlämnings_uppgift
{
    public static class TextColor
    {
        public static void TypeColored(Player player, string text)
        {
            var color = player.ClassName switch
            {
                "water" => ConsoleColor.Blue,
                "fire" => ConsoleColor.Red,
                "wind" => ConsoleColor.Green,
                _=> ConsoleColor.Gray
            };

            Console.ForegroundColor = color;
            Typewriter.WriteEach(text);
            Console.ResetColor();
        }
    }
}

