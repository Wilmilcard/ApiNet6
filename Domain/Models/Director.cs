using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Table("Director")]
    public class Director : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("DirectorId")]
        public int DirectorId { get; set; }
        public int MarcaId { get; set; }
        [StringLength(80)]
        [Column(TypeName = "VARCHAR(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci")]
        public string Nombre { get; set; }


        //Public Foreign Key
        public virtual Marca Marca { get; set; }
    }
}
