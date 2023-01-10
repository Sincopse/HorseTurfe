using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    internal class Program
    {
        static void Loja(Team team)
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
                    case 1: Shop.HorseShop(team); break;
                    case 2: Console.WriteLine("Saiu da Loja"); break;
                    default: Console.WriteLine("Opçao invalida"); Console.ReadKey(); break;
                }
            } while (option != 2);
        }

        static void Race(Team team)
        {
            int option;

            do
            {
                Console.Clear();
                UI.DrawBox("     Corridas;1 - Iniciar corrida;2 - ;3 - Loja;4 - Sair");
                Console.Write("\n Escolha a sua opção: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1: Console.WriteLine("corridas"); break;
                    case 2: Console.WriteLine("Gerir Team"); break;
                    case 3: Loja(); break;
                    case 4: break;
                    default: Console.WriteLine("Opçao invalida"); Console.ReadKey(); break;
                }
            } while (option != 4);
        }

        static void Main(string[] args)
        {
            Team team = new Team();
            int option;

            do
            {
                Console.Clear();
                UI.DrawBox("     Menu;1 - Corridas;2 - Gerir Team;3 - Loja;4 - Sair");
                Console.Write("\n Escolha a sua opção: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1: Race(); break;
                    case 2: Console.WriteLine("Gerir Team"); break;
                    case 3: Loja(team); break;
                    case 4: Console.WriteLine("Saiu do Jogo"); break;
                    default: Console.WriteLine("Opçao invalida"); Console.ReadKey(); break;
                }
            } while (option != 4);
        }
    }
}