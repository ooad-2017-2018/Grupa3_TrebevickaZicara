using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations.Schema;

namespace gbookWinAPP.Models
{
   [Table("OOADClanModel")]
    public class ClanModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors ")]
        public ClanModel()
        {
            knjigeCLID = new HashSet<KnjigaModel>();
        }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Key]
        public int ClanID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CC2227: CollectionPropertyesShouldBeReadOnly")]
        public virtual ICollection<KnjigaModel> knjigeCLID { get; set; }

        [Required]
        [StringLength(25)]
        public string Ime { get; set; }
        [Required]
        [StringLength(25)]
        public string Prezime { get; set; }
        [Required]
        [StringLength(20)]
        public string UserName { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        public DateTime DatumUclanjenja { get; set; }

        
        [Required]
        [StringLength(25)]
        public string Grad { get; set; }

        public string Adresa { get; set; }
        [Required]
        [StringLength(15)]
        public string BrojTel { get; set; }

        public string Email { get; set; }
      
    }
}