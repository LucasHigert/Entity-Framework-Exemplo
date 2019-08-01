using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    //"SistemaContext" Vai ter uma herança da classe chamada Context
    public class SistemaContext : DbContext
    {
        //Através dessa classe que será acessado o banco de dados

        public DbSet<Animal> Animais { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }




        public SistemaContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\ExemploEntityFramework.mdf;Integrated Security=True;Connect Timeout=30")
        {
            //Desabilita, fazendo banco da dados manualmente
            Database.SetInitializer<SistemaContext>(null);
        }


    }
}
