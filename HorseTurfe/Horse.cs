using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    public enum Breed //Raça do cavalo
    {
        None = 0,
        Arabe = 1,
        Morgan = 2,
        Crioulo = 3
    }

    public class Horse
    {
        public int Age;      // Idade, entre 5 a 25 anos
        public int Speed; // Velocidade, entre 1 a 20
        public int Control;  // Controlo na pista, entre 1 a 20

        public float Price;     // Preço do cavalo

        public Breed Breed;   // Raça do cavalo

        public Horse()
        {
            this.Age = 0;
            this.Speed = 0;
            this.Control = 0;
            this.Price = 0;
            this.Breed = Breed.None;
        }

        public Horse(int age, int speed, int control, float price, Breed breed)
        {
            this.Age = age;
            this.Speed = speed;
            this.Control = control;
            this.Price = price;
            this.Breed = breed;
        }

        static public Horse GenerateHorse()
        {
            Random rnd = new Random();

            return new Horse
            {
                Age = rnd.Next(1, 26),
                Speed = rnd.Next(1, 21),
                Control = rnd.Next(1, 21),
                Price = 2000,
                Breed = (Breed)rnd.Next(1, 4)
            };
        }

        public override string ToString()
        {
            return "Cavalo " + Breed + " de " + Age + " anos";
        }
    }
}
