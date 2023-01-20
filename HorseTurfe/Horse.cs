using System;
using System.CodeDom.Compiler;
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
        Male = 0,
        Female = 1
    }

    [Serializable]
    public class Horse
    {
        public string Name { get; set; }
        public int Age { get; }      // Idade, entre 2 a 10 anos
        public int Speed;            // Velocidade, entre 1 a 20
        public int Toughness;        // Resistencia, entre 1 a 20
        public int Control;          // Controlo na pista, entre 1 a 20

        public float Price;          // Preço do cavalo

        public int Distance;       // Distancia do cavalo na corrida

        private Sex sex { get; }     // Sexo do cavalo
        private Breed breed { get; } // Raça do cavalo

        public bool canCouple(Horse horse) => this.sex != horse.sex;

        public Horse(int age, int speed, int control, int toughness, float price, Breed breed, Sex sex)
        {
            this.Name = "Não batizado";
            this.Age = age;
            this.Speed = speed;
            this.Control = control;
            this.Toughness = toughness;
            this.Price = price;
            this.breed = breed;
            this.sex = sex;
            this.Distance = 0;
        }

        static public Horse GenerateHorse(Random rnd)
        {
            Sex sex = (Sex)rnd.Next(2);

            Breed breed = (Breed)rnd.Next(1, 4);

            int age = rnd.Next(2, 11);
            int speed = (int)(16 * Math.Sin(0.25 * age + 0.4) + rnd.Next(-2, 3));
            int control = rnd.Next(2, 11);
            int toughness = rnd.Next(2, 11);
            int price = rnd.Next(100, 10000);

            return new Horse(age, speed, control, toughness, price, breed, sex);
        }

        static public Horse GenerateHorse(Random rnd, Breed inputbreed)
        {
            Sex sex = (Sex)rnd.Next(2);

            Breed breed = inputbreed;

            int age = 2;
            int speed = (int)(16 * Math.Sin(0.25 * age + 0.4) + rnd.Next(-2, 3));
            int control = rnd.Next(2, 11);
            int toughness = rnd.Next(2, 11);
            int price = rnd.Next(100, 10000);

            return new Horse(age, speed, control, toughness, price, breed, sex);
        }

        static public Horse BreedHorses(Horse horse1, Horse horse2)
        {
            Random rnd = new Random();
            int breed = rnd.Next(2);

            if (breed == 1)
            {
                return GenerateHorse(rnd, horse1.breed);
            }
            else return GenerateHorse(rnd, horse2.breed);
        }

        public override string ToString()
        {
            return "Cavalo " + breed + " de " + Age + " anos";
        }

        public void Move(int distance) => Distance += distance;
    }
}
