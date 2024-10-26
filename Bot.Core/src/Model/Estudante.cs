
using Bot.Core.src.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bot.Core.Model
{
    [Table("estudante")]
    public class Estudante : OrdinaryEntity
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("cpf")]
        public string? Cpf { get; set; }

        [Column("senha")]
        public string? Senha { get; set; }

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("email_institucional")]
        public string? EmailInstitucional { get; set; }

        [Column("ra")]
        public string? Ra { get; set; }

        [Column("ciclo")]
        public string? Ciclo { get; set; }

        [Column("pp")]
        public string? PP { get; set; }

        [Column("pr")]
        public string? PR { get; set; }

        [Column("autenticado")]
        public bool Autenticado { get; set; } = false;


        [ForeignKey("Preferencia")]
        [Column("preferencia_id")]
        public int? PreferenciaId { get; set; }

        public virtual Preferencia? Preferencia { get; set; }

        public virtual ICollection<Materia>? Materias { get; set; }

        public Estudante() { }

        public Estudante(string cpf, string senha) {
            this.Cpf = cpf;
            this.Senha = senha;
        }

    }
}
