using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bot.Core.Model;

namespace Bot.Core.src.Model
{
    [Table("materia")]
    public class Mensagem : OrdinaryEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id")]
        private String? Nome { get; set; }

        [Column("id")]
        private String? Numero { get; set; }

        [Column("id")]
        private String? Texto { get; set; }

        [ForeignKey("Preferencia")]
        [Column("preferencia_id")]
        private int? preferenciaId;

        public virtual Preferencia? preferencia { get; set; }


        public Mensagem() 
        {

        }

        public Mensagem(string nome, string numero, string texto)
        {
            this.Nome = nome;
            this.Texto = texto;
            this.Numero = numero;
        }
    }
}
