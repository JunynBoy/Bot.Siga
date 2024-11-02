using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bot.Core.src.Model
{
    [Table("mensagem")]
    public class Mensagem : OrdinaryEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("whatsapp")]
        public string? Whatsapp { get; set; }

        [Column("is_atualizar_por_email")]
        public bool IsAtualizarPorEmail { get; set; } = false;

        [Column("is_atualizar_por_whatsapp")]
        public bool IsAtualizarPorWhatsapp { get; set; } = false;

        [Column("texto")]
        public string? Texto { get; set; }

        [ForeignKey("Preferencia")]
        [Column("preferencia_id")]
        public int? PreferenciaId { get; set; }

        public virtual Preferencia? Preferencia { get; set; }

        public Mensagem(){}

        public Mensagem(string? nome, string? email, string? whatsapp, bool isAtualizarPorEmail, bool isAtualizarPorWhatsapp, string? texto, int? preferenciaId)
        {
            Nome = nome;
            Email = email;
            Whatsapp = whatsapp;
            IsAtualizarPorEmail = isAtualizarPorEmail;
            IsAtualizarPorWhatsapp = isAtualizarPorWhatsapp;
            Texto = texto;
            PreferenciaId = preferenciaId;
        }
    }
}
