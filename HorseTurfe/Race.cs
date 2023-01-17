using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    public class Race
    {
        List<Horse> horses;

        public Race(List<Horse> horses)
        {
            this.horses = horses;
        }

        public void Run()
        {
            Random rand = new Random();
            List<int> horsePositions = new List<int>();
            for (int i = 0; i < horses.Count; i++)
            {
                horsePositions.Add(0);
            }

            while (true)
            {
                // Update da posiçao dos cavalos
                for (int i = 0; i < horses.Count; i++)
                {
                    horses[i].Move(rand.Next(10));
                    horsePositions[i] = horses[i].Distance;
                }

                UI.DrawRace(); //se n tiver a dar alguem que crie a class

                // Checka o vencedor
                for (int i = 0; i < horses.Count; i++)
                {
                    if (horses[i].Distance >= 100)
                    {
                        Console.WriteLine($"{horses[i].Name} has won the race!");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                        return;
                    }
                }
            }
        }
    }
}
