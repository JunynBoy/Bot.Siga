using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.src.Model
{
    [Table("preferencia")]
    public class Preferencia
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("is_atualizar_por_email")]
        public bool AtualizarPorEmail { get; set; } = false;

        [Column("whatsapp")]
        public string? Whatsapp { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [DefaultValue(null)]
        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }
    }
}
