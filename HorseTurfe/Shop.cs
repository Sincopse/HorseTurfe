using System;
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

        public static  void RemoveHorse(List<Horse> horses, Horse horse)
        {
            horses.Remove(horse);
        }


       

        public static  void HorseShop(Team team)
        {   
            List<Horse> horses = new List<Horse>();
            int option = 0;
            string PassWord ;

            
            UI.DrawBox(" Loja (atualiza em 15min);1 - Comprar Cavalos;2 - Sair;  " +
                ";" +
                ";" +
                ";" +
                ";" +
                "3-Admistraçao da loja");
            Console.Write("\n Escolha a sua opção: ");


            option =int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1: foreach (Horse Horse in horses)
                    {
                        Console.WriteLine(horses);
                    }
                    break;
                case 2: Console.WriteLine("Quitting...");
                    break;
                
                case 3: PassWord = Console.ReadLine();
                    if (PassWord == ("EDJD"))
                        {
                        Console.WriteLine("PassWord Correta.");
                        Console.WriteLine("Introduça os cavalos para venda no seguinte formato" +
                            "");//ver formato



                        }
                    break;

                default:Console.WriteLine("Opçao invalida");
                    break;
            }
        }
    }
}