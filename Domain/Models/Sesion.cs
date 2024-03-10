using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Table("Sesion")]
    public class Sesion : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("SesionID")]
        public Guid SesionID { set; get; }
        //
        [Column("UserID")]
        public int UserID { set; get; }
        [Column("Token")]
        [StringLength(500)]
        public string Token { set; get; }
        [Column("Expiration_Date")]
        public DateTime Expiration_Date { set; get; }
        //
        [ForeignKey("UserID")]
        public User User { set; get; }
    }
}
