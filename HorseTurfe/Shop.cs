using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{

    public static class Shop
    {


        public static void AddHorse(List<Horse> horses, Horse horse)
        {
            horses.Add(horse);
        }

        public static void RemoveHorse(List<Horse> horses, Horse horse)
        {
            horses.Remove(horse);
        }




        public static void HorseShop(Player player)
        {
            Random rnd = new Random();
            List<Horse> horses = new List<Horse>();
            int option = 0;
            int optionhorse = 0;
            string TextAllHorse;

            Horse horse1 = Horse.GenerateHorse(rnd);
            Horse horse2 = Horse.GenerateHorse(rnd);
            Horse horse3 = Horse.GenerateHorse(rnd);
            Horse horse4 = Horse.GenerateHorse(rnd);


            Horse[] Allhorses = { horse1, horse2, horse3, horse4 };

            TextAllHorse = Allhorses[0].Price + " euros" + " - " + Allhorses[0].ToString() + ";" +
                           Allhorses[1].Price + " euros" + " - " + Allhorses[1].ToString() + ";" +
                           Allhorses[2].Price + " euros" + " - " + Allhorses[2].ToString() + ";" +
                           Allhorses[3].Price + " euros" + " - " + Allhorses[3].ToString();




            Console.Clear();
            UI.DrawBox("Cavalos disponiveis:;" + TextAllHorse + ";" + "5- Sair da Loja");
            Console.Write("\n Escolha o cavalo que deseja adquirir: ");
            if (!Int32.TryParse(Console.ReadLine(), out optionhorse))
            {
                optionhorse = -1;
            }
             

            if (optionhorse >= 1 && optionhorse <= 4)
            {
                UI.DrawBox(Allhorses[optionhorse - 1] + ";" + "É o que dejesa?" + ";" + "1-Confirmar" + ";" + "2- Voltar a loja");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }
               

                if (player.BuyHorse(Allhorses[optionhorse - 1]))
                {
                    Console.WriteLine("Compraste o cavalo por " + Allhorses[optionhorse - 1].Price + " euros.");

                }

                else
                {
                    Console.WriteLine("Não tens dinheiro para comprar este cavalo.");

                }



            }
            



        }
    }
}
