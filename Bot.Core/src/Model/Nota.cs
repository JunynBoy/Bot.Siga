using Bot.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.Model
{

    [Table("nota")]
    public class Nota
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("materia_id")]
        public int MateriaId { get; set; }

        [Column("aluno_id")]
        public int AlunoId { get; set; }


        [Column("p1")]
        public float P1 { get; set; }

        [Column("p2")]
        public float P2 { get; set; } 

        [Column("p3")]
        public float P3 { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [DefaultValue(null)]
        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }


        public Materia? Materia { get; set; }
        public Aluno? Aluno { get; set; }


        public Nota() { }
        
        public Nota(int materiaid , int alunoId, float p1, float p2, float p3)
        {
            this.MateriaId = materiaid;
            this.AlunoId = alunoId;
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
            this.CreatedAt = CreatedAt;

        }

    }
}
