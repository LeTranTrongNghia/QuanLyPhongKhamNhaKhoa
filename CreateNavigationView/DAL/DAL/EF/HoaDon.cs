namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            LichSuKhams = new HashSet<LichSuKham>();
        }

        [Key]
        public int maHoaDon { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngayThanhToan { get; set; }

        public int maThanhToan { get; set; }

        public int maDonThuoc { get; set; }

        public int maLamSan { get; set; }

        public int maCanLamSan { get; set; }

        public int maBenhNhan { get; set; }

        public int tongSoTien { get; set; }

        public virtual DichVuThanhToan DichVuThanhToan { get; set; }

        public virtual DONTHUOC DONTHUOC { get; set; }

        public virtual ThongTinCanLamSan ThongTinCanLamSan { get; set; }

        public virtual ThongTinLamSan ThongTinLamSan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuKham> LichSuKhams { get; set; }
    }
}
