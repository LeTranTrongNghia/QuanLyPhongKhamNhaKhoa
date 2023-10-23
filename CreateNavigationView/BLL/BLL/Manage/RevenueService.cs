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
    public class RevenueService
    {
        public List<DoanhThu> GetAll()
        {
            EFModels databaseNhaKhoa = new EFModels();
            return databaseNhaKhoa.DoanhThus.ToList();
        }

        public DoanhThu GetRevenue(DateTime date)
        {
            EFModels dbNhaKhoa = new EFModels();
            return dbNhaKhoa.DoanhThus.FirstOrDefault(p=>p.ngay == date);
        }

        public void AddRevenue(DoanhThu revenue)
        {
            EFModels databaseNhaKhoa = new EFModels();
            databaseNhaKhoa.DoanhThus.AddOrUpdate(revenue);
            databaseNhaKhoa.SaveChanges();
        }

        public List<DoanhThu> GetByMonth()
        {
            EFModels databaseNhaKhoa = new EFModels();

            return databaseNhaKhoa.DoanhThus.Where(p => p.ngay.Month == DateTime.Now.Month).ToList();
        }
        public List<DoanhThu> GetByQuater()
        {
            EFModels databaseNhaKhoa = new EFModels();
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddMonths(-3);
            return databaseNhaKhoa.DoanhThus.Where(p => p.ngay >= endDate && p.ngay <=startDate).ToList();
        }
        public List<DoanhThu> GetByYear()
        {
            EFModels databaseNhaKhoa = new EFModels();

            return databaseNhaKhoa.DoanhThus.Where(p => p.ngay.Year == DateTime.Now.Year).ToList();
        }

        public long GetTotalByMonth()
        {
            long sum = 0;
            //DatabaseNhaKhoa database = new DatabaseNhaKhoa();
            List<DoanhThu> doanhThus = GetByMonth();
            foreach (DoanhThu doanhThu in doanhThus)
                sum += doanhThu.loiNhuan;
            return sum;
        }

        public long GetTotalByQuater()
        {
            long sum = 0;
            //DatabaseNhaKhoa database = new DatabaseNhaKhoa();
            List<DoanhThu> doanhThus = GetByQuater();
            foreach (DoanhThu doanhThu in doanhThus)
                sum += doanhThu.loiNhuan;
            return sum;
        }

        public long GetTotalByYear()
        {
            long sum = 0;
            //DatabaseNhaKhoa database = new DatabaseNhaKhoa();
            List<DoanhThu> doanhThus = GetByYear();
            foreach (DoanhThu doanhThu in doanhThus)
                sum += doanhThu.loiNhuan;
            return sum;
        }
    }
}
