using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gbookWinAPP.Models
{
    [Table("OOADKnjigaModel")]
    public class KnjigaModel
    {
        public KnjigaModel()
        {

        }

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KnjigaID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey ("ClanID")]
        public int ClanID { get; set; }



        // Navigation properties 
        public virtual ClanModel ClanModel { get; set; }
  

        [Required]
        [StringLength(255)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(255)]
        public string Autor { get; set; }

        [Required]
        [StringLength(255)]
        public string Izdavac { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ISBN { get; set; }

        public string DatumIzdavanja { get; set; }

        public string DatumVracanja { get; set; }

      
        
        
        
    }
}