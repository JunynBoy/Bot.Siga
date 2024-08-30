using Bot.Core.src.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bot.Core.Model
{


    [Table("faltas")]
    public class Faltas : OrdinaryEntity
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public int? Presencas { get; set; }

        [Column("codigo")]
        public int? Ausencias { get; set; }

        [Column("maximo_ausencias")]
        public int? MaximoAusencia { get; set; }

        [Column("observacoes")]
        public String? Observacoes { get; set; }

        public Faltas() { }

        public Faltas(int? presencas, int? ausencias, int? maximoAusencias)
        {
            this.Presencas = presencas;
            this.Ausencias = ausencias;
            this.MaximoAusencia = maximoAusencias;
        }



    }
}
