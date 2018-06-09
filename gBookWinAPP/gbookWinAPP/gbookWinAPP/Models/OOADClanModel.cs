namespace gbookWinAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OOADClanModel")]
    public partial class OOADClanModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OOADClanModel()
        {
            OOADKnjigaModels = new HashSet<OOADKnjigaModel>();
        }

        public int ID { get; set; }

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

        public DateTime DatumUclanjenja { get; set; }

        [Required]
        [StringLength(25)]
        public string Grad { get; set; }

        public string Adresa { get; set; }

        [Required]
        [StringLength(15)]
        public string BrojTel { get; set; }

        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOADKnjigaModel> OOADKnjigaModels { get; set; }
    }
}
