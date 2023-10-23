namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinNhanVien")]
    public partial class ThongTinNhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinNhanVien()
        {
            LichSuKhams = new HashSet<LichSuKham>();
            NhapLieux = new HashSet<NhapLieu>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        [Key]
        public int maNhanVien { get; set; }

        [Required]
        [StringLength(200)]
        public string hoVaTen { get; set; }

        public bool gioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime namSinh { get; set; }

        [Required]
        [StringLength(15)]
        public string soDienThoai { get; set; }

        [Required]
        public string diaChi { get; set; }

        public int maChucVu { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuKham> LichSuKhams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhapLieu> NhapLieux { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
