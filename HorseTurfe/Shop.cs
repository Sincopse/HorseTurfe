using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    internal class Shop
    {
        public static void ConfirmeShop()
        {
            UI.DrawBox( "; 1- Para Confirmar; 0-Para voltar a escoher o cavalo");

        }

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



            do //ainda ver se esta bem
            {
                Console.Clear();
                UI.DrawBox("Loja (atualiza em 15 min);" + texto + ";9-Atualizar");
                Console.Write("\n Escolha a sua opção: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = 0;
                }

                switch (option)
                {
                    case 1:UI.DrawBox("O Cavalo Escolhido foi:" + horses[0]);
                        ConfirmeShop();
                        break;
                    case 2: UI.DrawBox("O Cavalo Escolhido foi:" + horses[1]);
                        ConfirmeShop();
                        break;
                    case 3:UI.DrawBox("O Cavalo Escolhido foi:" + horses[2] + "; 1- Para Confirmar; 0-Para voltar a escoher o cavalo");
                       /* if (option == 1)
                        {
                            Console.WriteLine("removeu o cavalo");
                        }*/
                        break;
                    case 4:UI.DrawBox("O Cavalo Escolhido foi:" + horses[2] + "; 1- Para Confirmar; 0-Para voltar a escoher o cavalo");
                        /*if(option == 1)
                        {
                            Console.WriteLine("removeu o cavalo");
                        }*/
                        break;
                    case 5: Console.WriteLine("A loja era atualizar"); break;
                    default: Console.WriteLine("Opçao invalida"); Console.ReadKey(); break;
                }
            } while (option != 9 );
        }

        
    }
}


