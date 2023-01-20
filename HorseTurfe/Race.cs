using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void Run(Player player)
        {
            Random rand = new Random();

            while (true)
            {
                // Update da posiçao dos cavalos
                foreach (var horse in horses)
                {
                    horse.Move(rand.Next(10));
                    int moveAmount = (horse.Speed + horse.Toughness + horse.Control) / 3 + rand.Next(3) - 1;
                    horse.Move(moveAmount);
                }

                Console.Clear();
                UI.DrawRace(horses);

                // Checka o vencedor
                foreach (var horse in horses)
                {
                    if (horse.Distance >= 200)
                    {
                        EndRace();
                        Console.WriteLine(horse.Name + " has won the race!");
                        UI.DrawBox(horse);
                        Console.WriteLine("\nPress any key to exit");
                        Console.ReadKey();
                        return;
                    }
                }
                Thread.Sleep(500);
            }
        }

        public void EndRace()
        {
            foreach (var horse in horses)
            {
                horse.Distance = 0;
            }
        }
    }
}
