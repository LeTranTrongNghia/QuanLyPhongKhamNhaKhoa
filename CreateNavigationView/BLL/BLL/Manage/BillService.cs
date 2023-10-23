using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DAL.EF;
using DAL.DAL.EF;

namespace NavigationView.BLL.Manage
{
    public class BillService
    {
        public List<HoaDon> GetAll()
        {
            EFModels database = new EFModels();
            return database.HoaDons.ToList();
        }

        public HoaDon GetBill(int idBill)
        {
            EFModels db = new EFModels();
            return db.HoaDons.FirstOrDefault(p=>p.maHoaDon == idBill);
        }

        public void AddOrUpdateBill(HoaDon bill)
        {
            EFModels db = new EFModels();
            db.HoaDons.AddOrUpdate(bill);
            db.SaveChanges();
        }

        public List<HoaDon> GetByMonth()
        {
            EFModels db = new EFModels();
            DateTime dateTime = DateTime.Now;
            return db.HoaDons.Where(p => p.ngayThanhToan.Month == dateTime.Month).ToList();
        }
        public List<HoaDon> GetByQuater()
        {
            EFModels db = new EFModels();
            DateTime dateStart = DateTime.Now;
            DateTime dateEnd = DateTime.Now.AddMonths(-3);
            return db.HoaDons.Where(p => p.ngayThanhToan >= dateEnd && p.ngayThanhToan <= dateStart).ToList();
        }
        public List<HoaDon> GetByYear()
        {
            EFModels db = new EFModels();
            DateTime dateTime = DateTime.Now;
            return db.HoaDons.Where(p => p.ngayThanhToan.Year == dateTime.Year).ToList();
        }

        public int LayTienThuNhapTrongNgay(DateTime date)
        {
            EFModels databaseNhaKhoa = new EFModels();
            /*
            var group = databaseNhaKhoa.HoaDons.GroupBy(p => p.ngayThanhToan).Select(gr => new
            {
                ngay = gr.Key,
                Total = gr.Sum(p => p.tongSoTien)
            });
            if (group == null)
                return 0;
            return group.FirstOrDefault(p => p.ngay == date).Total;
            */
            List<HoaDon> list = databaseNhaKhoa.HoaDons.Where((p) => p.ngayThanhToan == date).ToList();
            int money = 0;
            foreach (HoaDon n in list)
                money += n.tongSoTien;
            return money;
        }

    }
}
