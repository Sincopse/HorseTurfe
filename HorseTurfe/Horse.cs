using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        Crioulo = 3,
        Lusitano = 4
    }

    public enum Sex // Arranjar um sistema de procriação de cavalos
    {
        None = 0,
        Male = 1,
        Female = 2
    }

    public class Horse
    {
        public int Age;       // Idade, entre 2 a 10 anos
        public int Speed;     // Velocidade, entre 1 a 20
        public int Toughness; // Resistencia, entre 1 a 20
        public int Control;   // Controlo na pista, entre 1 a 20

        public float Price;   // Preço do cavalo

        public Sex Sex;       // Sexo do cavalo
        public Breed Breed;   // Raça do cavalo

        public Horse()
        {
            this.Age = 0;
            this.Speed = 0;
            this.Control = 0;
            this.Price = 0;
            this.Breed = Breed.None;
            this.Sex = Sex.None;
        }

        public Horse(int age, int speed, int control, float price, Breed breed, Sex sex)
        {
            this.Age = age;
            this.Speed = speed;
            this.Control = control;
            this.Price = price;
            this.Breed = breed;
            this.Sex = sex;
        }

        static public Horse GenerateHorse()
        {
            Random rnd = new Random();

            Breed breed = (Breed)rnd.Next(1, 4);

            int age = rnd.Next(2, 11);
            int speed = (int)(16 * Math.Sin(0.25 * age + 0.4) + rnd.Next(-2, 3));
            //int control = 
            //int price = 

            return new Horse
            {
                Age = age,
                Speed = speed,
                Control = rnd.Next(1, 21),
                Price = 2000,
                Breed = (Breed)rnd.Next(1, 4),
                Sex = (Sex)rnd.Next(1, 3)
            };
        }

        public override string ToString()
        {
            return "Cavalo " + Breed + " de " + Age + " anos";
        }
    }
}
