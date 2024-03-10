using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Table("Protagonista_Juego")]
    public class ProtagonistaJuego : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("ProtagonistaJuegoId")]
        public int ProtagonistaJuegoId { get; set; }
        public int JuegoId { get; set; }
        public int ProtagonistaId { get; set; }

        //Public Foreign Key
        public virtual Juego Juego { get; set; }
        public virtual Protagonista Protagonista { get; set; }
    }
}
