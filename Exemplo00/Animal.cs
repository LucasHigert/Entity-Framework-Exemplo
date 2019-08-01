using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    //Dentro dos colchetes é um Data attribute
    [Table("animais")]
    public class Animal
    {
        
        //Key serve pra dizer que é uma primary key
        
        [Key,Column("id")]
        public int Id { get; set; }


        [Column("nome")]
        public string Nome { get; set; }

        //"extinto" nome da coluna no banco de dados
        
        [Column("extinto")]
        public bool Extinto { get; set; }

        //Essa propriedade não está mapeada no banco de dados, não há uma coluna chamada IMC
        /*[NotMapped]
        public decimal IMC { get; set; }*/


    }
}
