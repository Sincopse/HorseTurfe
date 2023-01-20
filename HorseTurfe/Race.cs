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

            int option;
            string textAllHorse = "";

            do
            {
                textAllHorse = "";
                for (int i = 0; i < player.Horses.Count; i++)
                {
                    textAllHorse += (i + 1) + " - " + player.Horses[i] + ';';
                }
                textAllHorse += ";0 - Voltar";

                Console.Clear();
                UI.DrawBox(textAllHorse);
                Console.Write("\n Escolha a sua opção: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }

                if (option < 0 || option > player.Horses.Count)
                {
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
                else if (option != 0)
                {
                    Console.Clear();
                    horses[0] = player.Horses[option - 1];
                    option = 0;
                }
            } while (option != 0);

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
