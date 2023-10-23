namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONTHUOC")]
    public partial class DONTHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONTHUOC()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public int maDonThuoc { get; set; }

        [Required]
        [StringLength(300)]
        public string tenDonThuoc { get; set; }

        public int soLuong { get; set; }

        public int donGia { get; set; }

        public int thanhTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
