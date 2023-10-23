namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinBaoHanh")]
    public partial class ThongTinBaoHanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinBaoHanh()
        {
            ChuanDoanDieuTris = new HashSet<ChuanDoanDieuTri>();
        }

        [Key]
        public int maBaoHanh { get; set; }

        [Required]
        [StringLength(200)]
        public string tenLaboBaoHanh { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngayHetHanBaoHanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuanDoanDieuTri> ChuanDoanDieuTris { get; set; }
    }
}
