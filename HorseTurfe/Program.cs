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
        static void Main(string[] args)
        {
            int option;

            do {
                Console.Clear();
                Console.Write("\n ╔═══════════════════╗" +
                              "\n ║        MENU       ║" +
                              "\n ║ 1 - Corridas      ║" +
                              "\n ║ 2 - Gerir Cavalos ║" +
                              "\n ║ 3 - Loja          ║" +
                              "\n ║ 4 - Sair          ║" +
                              "\n ╚═══════════════════╝" +
                              "\n\n Escolha a sua opção: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }

                switch(option)
                {
                    case 1: Console.WriteLine("corridas"); break;
                    case 2: Console.WriteLine("gerir cavalos"); break;
                    case 3: Console.WriteLine("loja"); break;
                    case 4: Console.WriteLine("Saiu do Jogo"); break;
                    default: Console.WriteLine("Opçao invalida"); break;
                }
                Console.ReadKey(); 
            
            } while (option != 4);
        }
    }
}