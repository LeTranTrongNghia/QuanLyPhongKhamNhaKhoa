namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuKham")]
    public partial class LichSuKham
    {
        [Key]
        public int maLichSuKham { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngayKham { get; set; }

        public int maHoaDon { get; set; }

        public int maNhanVien { get; set; }

        public int maBenhNhan { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual ThongTinBenhNhan ThongTinBenhNhan { get; set; }

        public virtual ThongTinNhanVien ThongTinNhanVien { get; set; }
    }
}
