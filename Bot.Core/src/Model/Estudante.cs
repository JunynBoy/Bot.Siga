
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bot.Core.Model
{
    [Table("estudante")]
    public class Estudante
    { 

        [Key]
        [Column("id")]
        public int? Id { get; set; }

        [Column("cpf")]
        public string? Cpf { get; set; }

        [Column("senha")]
        public string? Senha { get; set; }

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("is_atualizar_por_email")]
        public bool AtualizarPorEmail { get; set; } = false;

        [Column("whatsapp")]
        public string? Whatsapp { get; set; }

        [Column("is_atualizar_por_whatsapp")]
        public bool AtualizarPorWhatsapp { get; set; } = false;

        [Column("autenticado")]
        public bool Autenticado { get; set; } = false;

        [Column("logado")]
        public bool Logado { get; set; } = false;

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [DefaultValue(null)]
        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }


        public virtual ICollection<MateriaMatriculado>? MateriasMatriculadas { get; set; }

        public Estudante() { }

        public Estudante(string? nome, string senha, string? email, bool atualizarPorEmail, string cpf , string? whatsapp , bool atualizarPorWhatsapp)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.AtualizarPorEmail = atualizarPorEmail;
            this.Whatsapp = whatsapp;
            this.AtualizarPorWhatsapp = atualizarPorWhatsapp;
            this.Cpf = cpf;

            
            this.CreatedAt = DateTime.Now;
        }




     


    }
}
