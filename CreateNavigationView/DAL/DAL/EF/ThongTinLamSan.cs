namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinLamSan")]
    public partial class ThongTinLamSan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinLamSan()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public int maLamSan { get; set; }

        public int maChuanDoan { get; set; }

        public int maBenhNhan { get; set; }

        public virtual ChuanDoanDieuTri ChuanDoanDieuTri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public virtual ThongTinBenhNhan ThongTinBenhNhan { get; set; }
    }
}
