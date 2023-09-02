using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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

        [Column("professor")]
        public string Professor { get; set; }

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


    }
}
