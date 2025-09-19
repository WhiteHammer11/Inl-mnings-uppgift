using System.IO.Pipes;
using System.Net.Http.Headers;

namespace Inlämnings_uppgift
{
    internal class Program
    {
       public static void Main(string[] args)
        {

            Player player = Meny.MainMeny();


            Console.WriteLine();

            player.Introduce();

            Console.WriteLine();

            player.Stats();

            bool isPlaying = true;


            while (isPlaying == true && player.Hp > 0)
            {
                // Börja runda 2

                string answer = Meny.AdventureMeny(player);



                switch (answer)
                {
                    case "1":
                      

                        Mission.MissionTime(player);

                        break;

                    case "2":
                        player.Rest();
                        break;

                    case "3":
                        player.Stats();
                        break;

                    case "4":
                        Console.WriteLine("Coward said Zane");
                        isPlaying = false;
                        break;


                }





            }









        }
    }
}
