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
    public class InputMaterialService
    {
        public List<NhapLieu> GetAll()
        {
            EFModels db =  new EFModels();
            return db.NhapLieux.ToList();
        }

        public NhapLieu GetMaterialInput(int inputID)
        {
            EFModels db = new EFModels();
            return db.NhapLieux.FirstOrDefault(p=>p.maNhap == inputID);   
        }

        public void AddInputMaterial(NhapLieu input)
        {
            EFModels databaseNhaKhoa = new EFModels();
            databaseNhaKhoa.NhapLieux.Add(input);
            databaseNhaKhoa.SaveChanges();
        }

        public List<NhapLieu> GetByMonth()
        {
            EFModels db = new EFModels();
            DateTime dateTime = DateTime.Now;
            return db.NhapLieux.Where(p => p.ngay.Month == dateTime.Month).ToList();
        }
        public List<NhapLieu> GetByQuater()
        {
            EFModels db = new EFModels();
            DateTime dateStart = DateTime.Now;
            DateTime dateEnd = DateTime.Now.AddMonths(-3);
            return db.NhapLieux.Where(p => p.ngay >= dateEnd && p.ngay <= dateStart).ToList();
        }
        public List<NhapLieu> GetByYear()
        {
            EFModels db = new EFModels();
            DateTime dateTime = DateTime.Now;
            return db.NhapLieux.Where(p => p.ngay.Year == dateTime.Year).ToList();
        }

        public int LayTienNhapLieuTrongNgay(DateTime date)
        {
            EFModels databaseNhaKhoa = new EFModels();
            
            List<NhapLieu> list = databaseNhaKhoa.NhapLieux.Where((p) => p.ngay == date).ToList();
            int money = 0;
            foreach (NhapLieu n in list)
                money += n.thanhTien;
            return money;
            
        }
    }
}
