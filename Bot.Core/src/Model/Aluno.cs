
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bot.Core.Model;
using System.Numerics;

namespace Bot.Core.Model
{
    [Table("Aluno")]
    public class Aluno
    { 

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("atualizar-por-email")]
        public bool AtualizarPorEmail { get; set; }

        [Column("whatsapp")]
        public string? Whatsapp { get; set; }

        [Column("atualizar-por-whatsapp")]
        public bool AtualizarPorWhatsapp { get; set; }


        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [DefaultValue(null)]
        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        [Column("autenticado")]
        public bool autenticado { get; set; }

        [Column("logado")]
        public bool logado { get; set; }

        public virtual ICollection<Nota>? Notas { get ; set; }

        public Aluno() { }

        public Aluno(string? nome, string senha, string? email, bool atualizarPorEmail, string cpf , string? whatsapp , bool atualizarPorWhatsapp)
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
