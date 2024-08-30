using Bot.Core.src.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bot.Core.Model
{

    [Table("notas")]
    public class Notas : OrdinaryEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("p1")]
        public float? P1 { get; set; } = 0.0f;

        [Column("p2")]
        public float? P2 { get; set; } = 0.0f;

        [Column("p3")]
        public float? P3 { get; set; } = 0.0f;

        [Column("media_final")]
        public float? MediaFinal { get; set; }

        [Column("observacoes")]
        public String? Observacoes { get; set; }



        public Notas() { }

        public Notas(Materia materiaMatriculado, float p1, float p2, float p3)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
            this.CreatedAt = CreatedAt;

        }

    }
}
