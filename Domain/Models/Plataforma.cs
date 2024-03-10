using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Table("Plataforma")]
    public class Plataforma : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("PlataformaId")]
        public int PlataformaId { get; set; }
        [StringLength(80)]
        [Column(TypeName = "VARCHAR(80) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string Nombre { get; set; }
    }
}
