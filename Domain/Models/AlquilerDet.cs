using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Table("Alquiler_Det")]
    public class AlquilerDet : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("AlquilerDetId")]
        public int AlquilerDetId { get; set; }
        public int Cantidad { get; set; }
        public int AlquilerId { get; set; }
        public int JuegoId { get; set; }
        public double Valor { get; set; }

        //public Foreign Keys
        public virtual Alquiler Alquiler { get; set; }
        public virtual Juego Juego { get; set; }
    }
}
