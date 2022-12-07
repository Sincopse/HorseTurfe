using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    public enum Raca //Raça do cavalo
    {
        Nenhuma = 0,
        Arabe = 1,
        Morgan = 2,
        Crioulo = 3
    }

    public class Horse
    {
        private int idade;      // Idade, entre 2 a 15 anos
        private int velocidade; // Velocidade, entre 1 a 20
        private int controlo;  // Controlo na pista, entre 1 a 20

        public int Preco;     // Preço do cavalo

        public Raca Raca;   // Raça do cavalo

        public Horse()
        {
            this.idade = 0;
            this.velocidade = 0;
            this.controlo = 0;
            this.Preco = 0;
            this.Raca = Raca.Nenhuma;
        }

        public override string ToString()
        {
            return "Return Cavalo " + Raca + " de " + idade + " anos";
        }
    }
}
