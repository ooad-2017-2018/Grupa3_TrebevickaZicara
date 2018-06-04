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
        /*   public KnjigaModel()
           {
               Get_CLIIDS = new HashSet<KnjigaModel>();
           }
           public virtual ICollection<KnjigaModel> Get_CLIIDS { get; set; }

           [Required]
           [Key]
           [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
           public int KnjigaID { get; set; }

           public int ClanID { get; set; }

           [ForeignKey("ClanID")]
           // Navigation properties 
           public virtual ClanModel ClanModel { get; set; }

       */

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KorisnikKnige { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KnjigaID { get; set; }

        public virtual ClanModel OOADClanovi { get; set; }

        public virtual KnjigaModel OOADKnjige { get; set; }



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