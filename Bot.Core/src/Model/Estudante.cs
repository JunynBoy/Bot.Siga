
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bot.Core.src.Model;

namespace Bot.Core.Model
{
    [Table("estudante")]
    public class Estudante
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

        [Column("logado")]
        public bool Logado { get; set; } = false;


        [ForeignKey("Preferencia")]
        [Column("preferencia_id")]
        public int? PreferenciaId { get; set; }

        public virtual Preferencia? Preferencia { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [DefaultValue(null)]
        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }


        public virtual ICollection<MateriaMatriculado>? MateriasMatriculadas { get; set; }

        public Estudante() { }

        public Estudante(string? nome, string senha, string cpf)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Cpf = cpf;
            
            this.CreatedAt = DateTime.Now;
        }




     


    }
}
