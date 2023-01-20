using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    public static class BlackMarket
    {
        static private Horse GenerateBMHorse()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);

            Sex sex = (Sex)rnd.Next(2);

            Breed breed = (Breed)rnd.Next(1, 4);

            int age = rnd.Next(5, 16);
            int speed = (int)(19 * Math.Sin(0.25 * age + 0.6) + rnd.Next(4, 6));
            int control = rnd.Next(5, 16);
            int toughness = rnd.Next(8, 17);
            int price = rnd.Next(5001, 20000);

            return new Horse(age, speed, control, toughness, price, breed, sex);
        }

        static private List<Item> items = new List<Item>()
        {
            new Item { Boost = 2, Name = "Saddle of Speed", Price = 6000 },
            new Item { Boost = 4, Name = "Horseshoes of Acceleration", Price = 8000 },
            new Item { Boost = 3, Name = "Whistle of Stamina", Price = 7000 },
            new Item { Boost = 5, Name = "Blinkers of Focus", Price = 1000 },
            new Item { Boost = 1, Name = "Bridle of Control", Price = 1000 }
        };

        static private List<Item> GenerateRandomItems()
        {
            Random rnd = new Random();
            List<Item> generatedItems = new List<Item>();

            foreach (var item in items)
            {
                if (rnd.Next(0, 2) == 0)
                {
                    generatedItems.Add(item);
                }
            }

            return generatedItems;
        }

        static public void MercadoNegroMenu(Player player)
        {
            int option;
            List<Item> availableItems = GenerateRandomItems();
            availableItems = availableItems.Take(5).ToList();

            do
            {
                Console.Clear();
                UI.DrawBox("     Mercado Negro;1 - Comprar " + availableItems[0].Name + ";2 - Comprar " + availableItems[1].Name + ";3 - Comprar " + availableItems[2].Name + ";4 - Sair");
                Console.Write("\n Escolha a sua opção: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1:
                    case 2:
                    case 3:
                        if (player.Money < availableItems[option - 1].Boost)
                        {
                            Console.WriteLine("Não tem dinheiro suficiente para comprar este item.");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Comprou " + availableItems[option - 1].Name + " por " + availableItems[option - 1].Boost + " euros");
                        player.Money -= availableItems[option - 1].Boost;
                        player.Items.Add(availableItems[option - 1]);
                        break;
                    case 4:
                        Console.WriteLine("Saiu do Mercado Negro");
                        break;
                    default:
                        Console.WriteLine("Opçao inválida");
                        Console.ReadKey();
                        break;
                }
            } while (option != 4);
        }
    }
}