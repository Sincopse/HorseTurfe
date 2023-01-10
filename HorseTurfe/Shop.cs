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
                "" +
                "" +
                "" +
                "" +
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








/* 



      public void AddHorse(Horse horse)
      {
          horses.Add(horse);
      }

      public void RemoveHorse(Horse horse)
      {
          horses.Remove(horse);
      }
  }
}

/* public static void ConfirmeShop()
{    


   UI.DrawBox( "; 1- Para Confirmar; 0-Para voltar a escoher o cavalo");

}



public void HorseList()
{
   private List<Horse> horses;









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
       UI.DrawBox("Loja (atualiza em 15 min);" + texto + ";5-Atualizar;9-Voltar");
       Console.Write("\n Escolha a sua opção: ");

       if (!Int32.TryParse(Console.ReadLine(), out option))
       {
           option = -1;
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
               if (option == 1)
               {
                   Console.WriteLine("removeu o cavalo");
               }
               break;
           case 4:UI.DrawBox("O Cavalo Escolhido foi:" + horses[2] + "; 1- Para Confirmar; 0-Para voltar a escoher o cavalo");
               if(option == 1)
               {
                   Console.WriteLine("removeu o cavalo");
               }
               break;
           case 5: Console.WriteLine("A loja era atualizar"); break;


           default: Console.WriteLine("A voltar..."); Console.ReadKey(); break;
       }
   } while (option != 9 );
}






}







}
*/

