using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Bot.Core.Model
{


    [Table("materia")]
    public class Materia
    {


        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("codigo")]
        public string? Codigo { get; set; }

        [Column("professor")]
        public string? Professor { get; set; }

        [Column("turno")]
        public EnumTurnoMateria Turno { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [DefaultValue(null)]
        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Nota>? Notas { get; set; }

        public Materia() { }
        public Materia(string nome, string codigo, string professor, EnumTurnoMateria turno) {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Professor = professor;
            this.Turno = turno;

            this.CreatedAt = DateTime.Now;
        }



    }
}
