using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Inlämnings_uppgift;

public class Typewriter


{
    public static void WriteEach(String text, int delay = 1)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);

        }

        Console.WriteLine();
    }



}
