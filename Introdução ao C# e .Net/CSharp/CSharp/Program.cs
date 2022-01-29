using System;
using Classe;
using Interface;
using Enum;
namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Referenciando com ExemploClasse.cs
            Pessoa person = new Pessoa();

            person.Nome = "Pedro";
            person.Idade = 21;
            person.Estado = "SP";

            //Referenciando com ExemploInterface.cs
            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.NomeDono = "Pedro";
            animal.especie = "Cachorro";

            //Chamando ExemploEnum.cs
            var teste = (Pessoas)0; //Maneira 1 de chamar
            Pessoas pessoa2 = Pessoas.Caique; //Maneira 2 de chamar
        }
    }
}
