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

    [Table("notas")]
    public class Notas
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("p1")]
        public float? P1 { get; set; }

        [Column("p2")]
        public float? P2 { get; set; } 

        [Column("p3")]
        public float? P3 { get; set; }

        [Column("media_final")]
        public float? MediaFinal { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [DefaultValue(null)]
        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }


        public Notas() { }
        
        public Notas(MateriaMatriculado materiaMatriculado, float p1, float p2, float p3)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
            this.CreatedAt = CreatedAt;

        }

    }
}
