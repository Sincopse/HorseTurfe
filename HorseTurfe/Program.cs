using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    internal class Program
    {
        static void Loja(Player player)
        {
            int option;

            do
            {
                Console.Clear();
                UI.DrawBox("        Loja;1 - Comprar Cavalos;2 - Sair");
                Console.Write("\n Escolha a sua opção: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1: Shop.HorseShop(player); break;
                    case 2: Console.WriteLine("Saiu da Loja"); break;
                    default: Console.WriteLine("Opçao invalida"); Console.ReadKey(); break;
                }
            } while (option != 2);
        }

        static void Race(Player player)
        {
            Random rnd = new Random();
            List<Horse> horses = new List<Horse>();

            Horse horse1 = Horse.GenerateHorse(rnd);
            Horse horse2 = Horse.GenerateHorse(rnd);
            Horse horse3 = Horse.GenerateHorse(rnd);
            Horse horse4 = Horse.GenerateHorse(rnd);

            horses.Add(player.Horses[0]);
            horses.Add(horse2);
            horses.Add(horse3);
            horses.Add(horse4);

            Race race = new Race(horses);

            int option;

            do
            {
                Console.Clear();
                UI.DrawBox("     Corridas;1 - Iniciar corrida;3 - Loja;4 - Sair");
                Console.Write("\n Escolha a sua opção: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1: race.Run(player); break;
                    case 2: Console.WriteLine("Gerir Team"); break;
                    case 3: Loja(player); break;
                    case 4: break;
                    default: Console.WriteLine("Opçao invalida"); Console.ReadKey(); break;
                }
            } while (option != 4);
        }

        static void Inventory(Player player)
        {
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
                    UI.DrawBox(player.Horses[option - 1]);
                    Console.WriteLine("3 - Voltar");
                    Console.ReadKey();
                }
            } while (option != 0);
        }

        static void MainMenu(Player player)
        {
            int option;

            do
            {
                Console.Clear();
                if (Calendar.DayOfWeek() == "Sexta-Feira")
                {
                    UI.DrawBox("     Menu;1 - Corridas;2 - Gerir Cavalos;3 - Loja;4 - Calendário;5 - Sair;6 - MercadoNegro");
                    UI.DrawBox("UUUUUUuuuuUUU um  mercante chegou á cidade com descontos e itens manhosos!!!");
                    Console.Write("\n Escolha a sua opção: ");
                    if (!Int32.TryParse(Console.ReadLine(), out option))
                    {
                        option = -1;
                    }
                    switch (option)
                    {
                        case 1: Race(player); break;
                        case 2: Inventory(player); break;
                        case 3: Loja(player); break;
                        case 4: Console.Clear(); Calendar.ShowCalendar(); Console.ReadKey(); break;
                        case 5: Console.WriteLine("Saiu do Jogo"); break;
                        case 6: BlackMarket.MercadoNegroMenu(player); break;
                        default: Console.WriteLine("Opçao invalida"); Console.ReadKey(); break;
                    }
                }
                else
                {
                    UI.DrawBox($" Bom dia {player.Name};1 - Corridas;2 - Gerir Cavalos;3 - Loja;4 - Calendário;5 - Sair");
                    Console.Write("\n Escolha a sua opção: ");

                    if (!Int32.TryParse(Console.ReadLine(), out option))
                    {
                        option = -1;
                    }

                    switch (option)
                    {
                        case 1: Race(player); break;
                        case 2: Inventory(player); break;
                        case 3: Loja(player); break;
                        case 4: Calendar.ShowCalendar(); Console.ReadKey(); break;
                        case 5: Console.WriteLine("Saiu do Jogo"); break;

                        default: Console.WriteLine("Opçao invalida"); Console.ReadKey(); break;
                    }
                }
            } while (option != 5);
        }

        static Player CreatePlayer()
        {
            Random rnd = new Random(); 
            Player player = new Player("Player 1", 10000);
            int option;

            Horse horse1 = Horse.GenerateHorse(rnd);
            Horse horse2 = Horse.GenerateHorse(rnd);
            Horse horse3 = Horse.GenerateHorse(rnd);

            Console.Clear();
            Console.Write("\n Digita o teu nome: ");
            player.Name = Console.ReadLine();

            do
            {
                Console.Clear();
                UI.DrawBox("1 - " + horse1.ToString() + ";2 - " + horse2.ToString() + ";3 - " + horse3.ToString());
                Console.Write("\n Escolhe o teu primeiro cavalo: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1: player.Horses.Add(horse1); break;
                    case 2: player.Horses.Add(horse2); break;
                    case 3: player.Horses.Add(horse3); break;

                    default: Console.WriteLine("Opçao invalida"); Console.ReadKey(); break;
                }
            } while (option < 1 && option > 3);

            Console.Clear();
            Console.Write("\n Digita o nome para o teu cavalo: ");
            player.Horses[0].Name = Console.ReadLine();
            return player;
        }

        static void Main(string[] args)
        {
            Player player = new Player("Player 1", 1000);
            int option;

            //SoundPlayer music = new SoundPlayer("music.wav");
            //// Play the audio file
            //music.PlayLooping(); finding a way to change the volume

            do
            {
                Console.Clear();
                UI.DrawBox("     Menu;1 - Começar novo jogo;2 - Carregar jogo;3 - Sair");
                Console.Write("\n Escolha a sua opção: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1:
                        player = CreatePlayer();
                        MainMenu(player);
                        break;
                    case 2:
                        if (FileUtil.LoadFile() != null)
                        {
                            MainMenu(player);
                        }
                        else UI.DrawBox("Não tens nenhum jogo salvo"); break;
                    case 3:
                        UI.DrawBox("Deseja guardar o jogo?");
                        Console.Write("\n Escolha a sua opção: ");
                        if (Console.ReadLine() == "1") FileUtil.SaveFile(player);

                        break;

                    default: Console.WriteLine("Opçao invalida"); Console.ReadKey(); break;
                }
            } while (option != 3);
        }
    }
}