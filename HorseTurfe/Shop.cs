using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    internal class Shop
    {
        public static void HorseStock()
        {
           
            int option;
            string texto;

            Horse horse1 = Horse.GenerateHorse();
            Horse horse2 = Horse.GenerateHorse();
            Horse horse3 = Horse.GenerateHorse();
            Horse horse4 = Horse.GenerateHorse();

            Horse[] horses = {horse1, horse2, horse3, horse4};

            texto = horses[0].ToString() + ";" +
                    horses[1].ToString() + ";" +
                    horses[2].ToString() + ";" +
                    horses[3].ToString();



            do
            {
                Console.Clear();
                UI.DrawBox("Loja (atualiza em 15 min);" + texto);
                Console.Write("\n Escolha a sua opção: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1: Console.WriteLine("nice "); break;
                    case 2: Console.WriteLine("Saiu da Loja"); break;
                    default: Console.WriteLine("Opçao invalida"); Console.ReadKey(); break;
                }
            } while (option != 2);
        }

        
    }
}


// UI.DrawBox("        Loja;1 - Comprar Cavalos;2 - Sair");