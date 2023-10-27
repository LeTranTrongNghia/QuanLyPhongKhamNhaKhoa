using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.DAL.EF
{
    public partial class EFModels : DbContext
    {
        public EFModels()
            : base("name=EFModels")
        {
        }
        public class ChartData
        {
            public DateTime Ngay { get; set; }
            public double Profit { get; set; }
        }

        public class AP
        {
            [Key]
            public string tenBenhNhan { get; set; }
            public string lyDoDenKham { get; set; }
            public DateTime ngayKham { get; set; }
        }

        public class Bill
        {
            public string maHoaDon { get; set; }
            public int MaBenhNhan { get; set; }
            public string TenBenhNhan { get; set; }
            public int MaCanLamSan { get; set; }
            public string NoiDungChuanDoan { get; set; }
            public string LuaChonDieuTri { get; set; }
            public int TongSoTien { get; set; }
        }

        public List<Bill> GetBillItems()
        {
            var query = from hd in HoaDons
                        join ttn in ThongTinBenhNhans on hd.maBenhNhan equals ttn.maBenhNhan
                        join tls in ThongTinLamSans on hd.maLamSan equals tls.maLamSan
                        join cddt in ChuanDoanDieuTris on tls.maChuanDoan equals cddt.maChuanDoan
                        select new Bill
                        {
                            maHoaDon = hd.maHoaDon.ToString(),
                            TongSoTien = hd.tongSoTien,
                            MaBenhNhan = ttn.maBenhNhan,
                            TenBenhNhan = ttn.tenBenhNhan,
                            MaCanLamSan = hd.maCanLamSan,
                            NoiDungChuanDoan = cddt.noiDungChuanDoan,
                            LuaChonDieuTri = cddt.luaChonDieuTri
                        };

            return query.ToList();
        }

        public List<AP> GetAPItems()
        {
            var query = from ttn in ThongTinBenhNhans
                        join lsk in LichSuKhams on ttn.maBenhNhan equals lsk.maBenhNhan
                        select new AP
                        {
                            tenBenhNhan = ttn.tenBenhNhan,
                            lyDoDenKham = ttn.lyDoDenKham,
                            ngayKham = lsk.ngayKham
                        };

            return query.ToList();
        }

        public int CountLSK()
        {
            return Set<LichSuKham>().Count();
        }
        public int CountPatient()
        {
            return Set<ThongTinBenhNhan>().Count();
        }
        public decimal GetTotalProfit()
        {
            return DoanhThus.Sum(d => d.loiNhuan);
        }


        public virtual DbSet<ChuanDoanDieuTri> ChuanDoanDieuTris { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DichVuThanhToan> DichVuThanhToans { get; set; }
        public virtual DbSet<DoanhThu> DoanhThus { get; set; }
        public virtual DbSet<DONTHUOC> DONTHUOCs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LichSuKham> LichSuKhams { get; set; }
        public virtual DbSet<NhapLieu> NhapLieux { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThongTinBaoHanh> ThongTinBaoHanhs { get; set; }
        public virtual DbSet<ThongTinBenhNhan> ThongTinBenhNhans { get; set; }
        public virtual DbSet<ThongTinCanLamSan> ThongTinCanLamSans { get; set; }
        public virtual DbSet<ThongTinLamSan> ThongTinLamSans { get; set; }
        public virtual DbSet<ThongTinNhanVien> ThongTinNhanViens { get; set; }
        public virtual DbSet<VatLieu> VatLieux { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChuanDoanDieuTri>()
                .HasMany(e => e.ThongTinLamSans)
                .WithRequired(e => e.ChuanDoanDieuTri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.ThongTinNhanViens)
                .WithRequired(e => e.ChucVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DichVuThanhToan>()
                .Property(e => e.quetMa)
                .IsFixedLength();

            modelBuilder.Entity<DichVuThanhToan>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.DichVuThanhToan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DONTHUOC>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.DONTHUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.LichSuKhams)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.taiKhoanNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.matKhauNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinBaoHanh>()
                .HasMany(e => e.ChuanDoanDieuTris)
                .WithRequired(e => e.ThongTinBaoHanh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongTinBenhNhan>()
                .Property(e => e.soDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinBenhNhan>()
                .HasMany(e => e.LichSuKhams)
                .WithRequired(e => e.ThongTinBenhNhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongTinBenhNhan>()
                .HasMany(e => e.ThongTinCanLamSans)
                .WithRequired(e => e.ThongTinBenhNhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongTinBenhNhan>()
                .HasMany(e => e.ThongTinLamSans)
                .WithRequired(e => e.ThongTinBenhNhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongTinCanLamSan>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.ThongTinCanLamSan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongTinLamSan>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.ThongTinLamSan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongTinNhanVien>()
                .Property(e => e.soDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinNhanVien>()
                .HasMany(e => e.LichSuKhams)
                .WithRequired(e => e.ThongTinNhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongTinNhanVien>()
                .HasMany(e => e.NhapLieux)
                .WithRequired(e => e.ThongTinNhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongTinNhanVien>()
                .HasMany(e => e.TaiKhoans)
                .WithRequired(e => e.ThongTinNhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VatLieu>()
                .HasMany(e => e.NhapLieux)
                .WithRequired(e => e.VatLieu)
                .WillCascadeOnDelete(false);
        }
    }
}
