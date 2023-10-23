namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VatLieu")]
    public partial class VatLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VatLieu()
        {
            NhapLieux = new HashSet<NhapLieu>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maVatLieu { get; set; }

        [Required]
        [StringLength(200)]
        public string noiDung { get; set; }

        [Required]
        [StringLength(50)]
        public string dvt { get; set; }

        public int soLuong { get; set; }

        public int donGia { get; set; }

        public int thanhTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhapLieu> NhapLieux { get; set; }
    }
}
