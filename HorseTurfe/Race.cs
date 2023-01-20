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

        //public static int PromptUserToSelectHorse(List<Horse> horses)
        //{
        //    // Display the horses to the user
        //    for (int i = 0; i < horses.Count; i++)
        //    {
        //        Console.WriteLine($"{i + 1}. {horses[i].Name}");
        //    }
        //    int userSelection = -1;
        //    while (userSelection < 0 || userSelection >= horses.Count)
        //    {
        //        // Prompt the user to select a horse
        //        Console.Write("Selecione um cavalo pelo seu numero: ");
        //        string userInput = Console.ReadLine();
        //        if (!int.TryParse(userInput, out userSelection))
        //        {
        //            Console.WriteLine("Invalido, escolha um numero.");
        //        }
        //        else if (userSelection < 0 || userSelection >= horses.Count)
        //        {
        //            Console.WriteLine("Seleçao invalida, por favor escolha um numero entre 1 e " + horses.Count);
        //        }
        //    }
        //    return userSelection;
        //}

        //public void RacistHorse(Player player)
        //{
        //    this.horses = new List<Horse>();
        //    // Deixa escolher os cavalos
        //    int selectedHorseIndex = PromptUserToSelectHorse(player.Horses);
        //    this.horses.Add(player.Horses[selectedHorseIndex]);
        //    // Gera 3 cavalos a sorte
        //    Random rnd = new Random();
        //    for (int i = 0; i < 3; i++)
        //    {
        //        this.horses.Add(Horse.GenerateHorse(rnd));
        //    }
        //}

        public void Run(Player player)
        {
            Random rand = new Random();

            //PromptUserToSelectHorse(player.Horses);
            //RacistHorse(player);

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
