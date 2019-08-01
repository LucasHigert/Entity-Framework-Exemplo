using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaContext contexto = new SistemaContext();
            #region Inserir
            Animal animal = new Animal();
            animal.Nome = "TRex";
            animal.Extinto = false;

            contexto.Animais.Add(animal);
            contexto.SaveChanges();
            Console.WriteLine("registro salvo com sucesso");
            #endregion Inserir

            #region Apagar
            //-------- Apagar
            //Animal animalApagar = contexto.Animais.Where(x => x.Nome == "TRex").First(); //First sempre retorna o primeiro, ja que queremos que apague o primeiro da lista
            //contexto.Animais.Remove(animalApagar);
            //            contexto.SaveChanges();
            #endregion Apagar

            #region Alterar
            //-------- Alterar
            //var cachorro = contexto
            //    .Animais
            //    //.Where()
            //    .First(x => x.Id == 2);
            //cachorro.Nome = "Cachorro";
            //contexto.SaveChanges();
            #endregion Alterar

            #region Listar
            //List<Animal> animais = contexto
            //    .Animais
            //     .Where(x=> x.Extinto==false && x.Nome.Contains("a")) //LIKE é Contains
            //    .OrderBy(x => x.Nome)
            //    .ToList();


            //foreach (Animal animal in animais)
            //{
            //    Console.WriteLine($"{animal.Id}-{animal.Nome}-{ animal.Extinto}");
            //}
            #endregion Listar

            //Habilidade habilidade = new Habilidade();
            //habilidade.IdAnimal = 1;
            //habilidade.Nome = "Invisibilidade";

            //contexto.Habilidades.Add(habilidade);
            //contexto.SaveChanges();

            //var habilidades = contexto.Habilidades.ToList();

            //foreach(Habilidade habilidadeAux in habilidades)
            //{
            //    Console.WriteLine(habilidade.Nome);
            //}


            #region InserirRelacionado
            Habilidade habilidade = new Habilidade();
            habilidade.IdAnimal = 1;
            habilidade.Nome = "Invisibilidade";

                contexto.Habilidades.Add(habilidade);
            contexto.SaveChanges();
            #endregion InserirRelacionado

            var habilidades = contexto.Habilidades.ToList();
            foreach( Habilidade habilidadeAux in habilidades)
            {

                Console.WriteLine(habilidadeAux.Animal.Nome+"-"+habilidadeAux.Nome);
            }



        }
    }
}
