namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinCanLamSan")]
    public partial class ThongTinCanLamSan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinCanLamSan()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public int maCanLamSan { get; set; }

        public int huyetAp { get; set; }

        public bool mauKhoDong { get; set; }

        public bool benhTimBamSinh { get; set; }

        public bool thieuNangTriTue { get; set; }

        public string khac { get; set; }

        public int maBenhNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public virtual ThongTinBenhNhan ThongTinBenhNhan { get; set; }
    }
}
