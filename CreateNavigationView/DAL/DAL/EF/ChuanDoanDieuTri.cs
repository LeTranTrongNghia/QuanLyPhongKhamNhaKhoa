namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuanDoanDieuTri")]
    public partial class ChuanDoanDieuTri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuanDoanDieuTri()
        {
            ThongTinLamSans = new HashSet<ThongTinLamSan>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maChuanDoan { get; set; }

        [Required]
        [StringLength(200)]
        public string noiDungChuanDoan { get; set; }

        [Required]
        [StringLength(300)]
        public string luaChonDieuTri { get; set; }

        [Required]
        [StringLength(50)]
        public string donViTinh { get; set; }

        public int soLuong { get; set; }

        public int donGia { get; set; }

        public int maBaoHanh { get; set; }

        public int thanhTien { get; set; }

        public virtual ThongTinBaoHanh ThongTinBaoHanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinLamSan> ThongTinLamSans { get; set; }
    }
}
