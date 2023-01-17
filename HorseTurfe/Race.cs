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

        public void Run()
        {
            Random rand = new Random();
            bool hasWinner = false;

            while (true)
            {
                // Update da posiçao dos cavalos
                foreach (var horse in horses)
                {
                    horse.Move(rand.Next(10));
                }

                Console.Clear();
                if (!hasWinner)
                {
                    UI.DrawRace(horses); //se n tiver a dar alguem que crie a class
                }                        // Já criei :)

                // Checka o vencedor
                foreach (var horse in horses)
                {
                    if (horse.Distance >= 100)
                    {
                        hasWinner = true;
                        Console.WriteLine(horse.Name + " has won the race!");
                        Console.WriteLine("\nPress any key to exit");
                        Console.ReadKey();
                        return;
                    }
                }
                Thread.Sleep(500);
            }
        }
    }
}
