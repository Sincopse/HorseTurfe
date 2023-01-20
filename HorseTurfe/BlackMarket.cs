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
            new Item { Boost = 2, Name = "Saddle of Speed" },
            new Item { Boost = 4, Name = "Horseshoes of Acceleration" },
            new Item { Boost = 3, Name = "Whistle of Stamina" },
            new Item { Boost = 5, Name = "Blinkers of Focus" },
            new Item { Boost = 1, Name = "Bridle of Control" }
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
                UI.DrawBox("     Mercado Negro;1 - Comprar " + availableItems[0].Name + ";2 - Comprar " + availableItems[1].Name + ";3 - Comprar " + availableItems[2].Name + ";4 - Comprar " + availableItems[3].Name + ";5 - Comprar " + availableItems[4].Name + ";6 - Sair");
                Console.Write("\n Escolha a sua opção: ");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1:
                        Item item1 = availableItems[0];
                        if (player.Money < item1.Boost)
                        {
                            Console.WriteLine("Não tem dinheiro suficiente para comprar este item.");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Comprou " + item1.Name + " por " + item1.Boost + " euros");
                        player.Money -= item1.Boost;
                        player.Items.Add(item1);
                        break;
                    case 2:
                        Item item2 = availableItems[1];
                        if (player.Money < item2.Boost)
                        {
                            Console.WriteLine("Não tem dinheiro suficiente para comprar este item.");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Comprou " + item2.Name + " por " + item2.Boost + " euros");
                        player.Money -= item2.Boost;
                        player.Items.Add(item2);
                        break;
                    case 3:
                        Item item3 = availableItems[2];
                        if (player.Money < item3.Boost)
                        {
                            Console.WriteLine("Não tem dinheiro suficiente para comprar este item.");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Comprou " + item3.Name + " por " + item3.Boost + " euros");
                        player.Money -= item3.Boost;
                        player.Items.Add(item3);
                        break;
                    case 4:
                        Item item4 = availableItems[3];
                        if (player.Money < item4.Boost)
                        {
                            Console.WriteLine("Não tem dinheiro suficiente para comprar este item.");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Comprou " + item4.Name + " por " + item4.Boost + " euros");
                        player.Money -= item4.Boost;
                        player.Items.Add(item4);
                        break;
                    case 5:
                        Item item5 = availableItems[4];
                        if (player.Money < item5.Boost)
                        {
                            Console.WriteLine("Não tem dinheiro suficiente para comprar este item.");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Comprou " + item5.Name + " por " + item5.Boost + " euros");
                        player.Money -= item5.Boost;
                        player.Items.Add(item5);
                        break;
                    case 6:
                        Console.WriteLine("Saiu do Mercado Negro");
                        break;
                    default:
                        Console.WriteLine("Opçao inválida");
                        Console.ReadKey();
                        break;
                }
            } while (option != 6);
        }
    }
}