using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Table("Plataforma_Juego")]
    public class PlataformaJuego : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("PlataformaJuegoId")]
        public int PlataformaJuegoId { get; set; }
        public int JuegoId { get; set; }
        public int PlataformaId { get; set; }

        //Public Foreign Key
        public virtual Plataforma Plataforma { get; set; }
        public virtual Juego Juego { get; set; }
    }
}
