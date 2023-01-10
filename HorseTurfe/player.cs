using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    public class Player : Team
    {
        public int Money;

        public Player(int startingMoney)
        {
            this.Money = startingMoney;
            this.Horses = new List<Horse>();
        }

        public string BuyHorse(Horse horse)
        {
            if (this.Money < horse.Price)
            {
                return "Não tens dinheiro para comprar este cavalo.";
            }

            this.Horses.Add(horse);
            this.Money -= (int)horse.Price;
            return "Compraste o cavalo por " + horse.Price + " euros.";
        }

        public void SellHorse(Horse horse)
        {
            if (!this.Horses.Contains(horse))
            {
                Console.WriteLine("Player does not own this horse.");
                return;
            }

            this.Horses.Remove(horse);
            this.Money += (int)(horse.Price * 0.9);
            Console.WriteLine("Successfully sold horse for " + (int)(horse.Price * 0.9) + " gold.");
        }
    }
}