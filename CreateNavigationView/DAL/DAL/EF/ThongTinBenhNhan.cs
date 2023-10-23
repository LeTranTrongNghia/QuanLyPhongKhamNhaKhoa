namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinBenhNhan")]
    public partial class ThongTinBenhNhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinBenhNhan()
        {
            LichSuKhams = new HashSet<LichSuKham>();
            ThongTinCanLamSans = new HashSet<ThongTinCanLamSan>();
            ThongTinLamSans = new HashSet<ThongTinLamSan>();
        }

        [Key]
        public int maBenhNhan { get; set; }

        [Required]
        [StringLength(200)]
        public string tenBenhNhan { get; set; }

        public bool gioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime namSinh { get; set; }

        [Required]
        [StringLength(15)]
        public string soDienThoai { get; set; }

        [Required]
        public string diaChi { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngayKhamDauTien { get; set; }

        [Required]
        public string lyDoDenKham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuKham> LichSuKhams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinCanLamSan> ThongTinCanLamSans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinLamSan> ThongTinLamSans { get; set; }
    }
}
