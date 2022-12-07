using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    public class Horse
    {
        private int idade; // Entre 2 a 15 anos
        private int velocidade; // 1 a 20
        private int controlo; // 1 a 20

        public Horse()
        {
            this.idade = -1;
            this.velocidade = -1;
            this.controlo = -1;
        }

        public Horse(int idade, int velocidade, int controlo)
        {
            this.idade = idade;
            this.velocidade = velocidade;
            this.controlo = controlo;
        }
    }
}
