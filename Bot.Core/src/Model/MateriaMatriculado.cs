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


    [Table("materia_matriculado")]
    public class MateriaMatriculado
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("codigo")]
        public string? Codigo { get; set; }

        [Column("professor")]
        public string? Professor { get; set; }

        [ForeignKey("Notas")]
        [Column("notas_id")]
        public int? NotasId { get; set; }

        public virtual Notas? Notas { get; set; }

        [ForeignKey("Estudante")]
        [Column("estudante_id")]
        public int? EstudanteId { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [DefaultValue(null)]
        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        public MateriaMatriculado() { }

        public MateriaMatriculado(string? nome, string? codigo, string? professor, Notas? nota) {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Professor = professor;
        }



    }
}
