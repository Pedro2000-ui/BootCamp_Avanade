using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IAnimal //Sempre deve começar com "I"
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IAnimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }
        void IAnimal.Especie(string especie)
        {
            this.especie = especie;
        }
    }
}
