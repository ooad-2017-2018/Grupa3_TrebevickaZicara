namespace gbookWinAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OOADKnjigaModel")]
    public partial class OOADKnjigaModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OOADKnjigaModel()
        {
            OOADKnjigaModel1 = new HashSet<OOADKnjigaModel>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KorisnikKnige { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KnjigaID { get; set; }

        [Required]
        [StringLength(255)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(255)]
        public string Autor { get; set; }

        [Required]
        [StringLength(255)]
        public string Izdavac { get; set; }

        public long ISBN { get; set; }

        public string DatumIzdavanja { get; set; }

        public string DatumVracanja { get; set; }

        public int? OOADKnjige_KorisnikKnige { get; set; }

        public int? OOADKnjige_KnjigaID { get; set; }

        public virtual OOADClanModel OOADClanModel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OOADKnjigaModel> OOADKnjigaModel1 { get; set; }

        public virtual OOADKnjigaModel OOADKnjigaModel2 { get; set; }
    }
}
