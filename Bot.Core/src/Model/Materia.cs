using Bot.Core.src.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bot.Core.Model
{
    [Table("materia")]
    public class Materia : OrdinaryEntity
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

        [Column("hrs_aula")]
        public int? HrsAula{ get; set; }

        [ForeignKey("Notas")]
        [Column("notas_id")]
        public int? NotasId { get; set; }

        public virtual Notas? Notas { get; set; }

        [ForeignKey("Faltas")]
        [Column("faltas_id")]
        public int? FaltasId { get; set; }

        public virtual Faltas? Faltas { get; set; }

        [ForeignKey("Estudante")]
        [Column("estudante_id")]
        public int? EstudanteId { get; set; }

        [Column("observacoes")]
        public String? Observacoes { get; set; }

        public Materia() { }

        public Materia(string? nome, string? codigo, string? professor, Notas? nota)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Professor = professor;
        }



    }
}
