using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bot.Core.src.Model
{
    [Table("preferencia")]
    public class Preferencia : OrdinaryEntity
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("is_atualizar_por_email")]
        public bool IsAtualizarPorEmail { get; set; } = false;

        [Column("is_atualizar_por_whatsapp")]
        public bool IsAtualizarPorWhatsapp { get; set; } = false;

        [Column("whatsapp")]
        public string? Whatsapp { get; set; }

    }
}
