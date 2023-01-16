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
            string TextAllHorse;

            Horse horse1 = Horse.GenerateHorse();
            Horse horse2 = Horse.GenerateHorse();
            Horse horse3 = Horse.GenerateHorse();
            Horse horse4 = Horse.GenerateHorse();
            Horse horse5 = Horse.GenerateHorse();

            Horse[] Allhorses = { horse1, horse2, horse3, horse4, horse5 };

            TextAllHorse = Allhorses[0].ToString() + ";" +
                           Allhorses[1].ToString() + ";" +
                           Allhorses[2].ToString() + ";" +
                           Allhorses[3].ToString() + ";" +
                           Allhorses[4].ToString() + ";" +
                           Allhorses[5].ToString();


            UI.DrawBox("Cavalos disponiveis:;"  + TextAllHorse + ";");
            Console.Write("\n Escolha o cavalo que deseja adquirir: ");


            option =int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    UI.DrawBox(Allhorses[0] + "e o que dejesa?" + ";" + "1-Confirmar" + ";" + "Voltar a loja");
                    option = int.Parse(Console.ReadLine());
                    do
                    {
                        switch(option)
                        {
                            case 1: Console.WriteLine("cavalo removido"); //descobrir como remover cavalo de um char
                                break;
                            case 2: break;
                        }
                           

                    } while (option != 2);
                    break;
                case 2:
                    UI.DrawBox(Allhorses[1] + "e o que dejesa?" + ";" + "1-Confirmar" + ";" + "Voltar a loja");
                    option = int.Parse(Console.ReadLine());
                    do
                    {
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("cavalo removido"); //descobrir como remover cavalo de um char
                                break;
                            case 2: break;
                        }


                    } while (option != 2);
                    break;
                case 3:
                    UI.DrawBox(Allhorses[2] + "e o que dejesa?" + ";" + "1-Confirmar" + ";" + "Voltar a loja");
                    option = int.Parse(Console.ReadLine());
                    do
                    {
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("cavalo removido"); //descobrir como remover cavalo de um char
                                break;
                            case 2: break;
                        }


                    } while (option != 2);
                    break;
                case 4:
                    UI.DrawBox(Allhorses[3] + "e o que dejesa?" + ";" + "1-Confirmar" + ";" + "Voltar a loja");
                    option = int.Parse(Console.ReadLine());
                    do
                    {
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("cavalo removido"); //descobrir como remover cavalo de um char
                                break;
                            case 2: break;
                        }


                    } while (option != 2);
                    break;
                case 5:
                    UI.DrawBox(Allhorses[4] + "e o que dejesa?" + ";" + "1-Confirmar" + ";" + "Voltar a loja");
                    option = int.Parse(Console.ReadLine());
                    do
                    {
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("cavalo removido"); //descobrir como remover cavalo de um char
                                break;
                            case 2: break;
                        }


                    } while (option != 2);
                    break;

                default:Console.WriteLine("Opçao invalida");
                    break;
            }
        }
    }
}