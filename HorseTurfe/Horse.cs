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

    public class Horse
    {
        public int Age;           // Idade, entre 2 a 10 anos
        public int Speed;         // Velocidade, entre 1 a 20
        public int Toughness;     // Resistencia, entre 1 a 20
        public int Control;       // Controlo na pista, entre 1 a 20

        public float Price;       // Preço do cavalo

        private Sex sex { get; } // Sexo do cavalo
        private Breed breed;      // Raça do cavalo

        public bool canCouple(Horse horse1, Horse horse2) => horse1.sex != horse2.sex;

        public Horse(int age, int speed, int control, int toughness, float price, Breed breed, Sex sex)
        {
            this.Age = age;
            this.Speed = speed;
            this.Control = control;
            this.Toughness = toughness;
            this.Price = price;
            this.breed = breed;
            this.sex = sex;
        }

        static public Horse GenerateHorse()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);

            Sex sex = (Sex)rnd.Next(2);

            Breed breed = (Breed)rnd.Next(1, 4);

            int age = rnd.Next(2, 11);
            int speed = (int)(16 * Math.Sin(0.25 * age + 0.4) + rnd.Next(-2, 3));
            int control = rnd.Next(2, 11);
            int toughness = rnd.Next(2, 11);
            int price = rnd.Next(100, 10000);

            return new Horse(age, speed, control, toughness, price, breed, sex);
        }

        public override string ToString()
        {
            return "Cavalo " + breed + " de " + Age + " anos";
        }
    }
}
