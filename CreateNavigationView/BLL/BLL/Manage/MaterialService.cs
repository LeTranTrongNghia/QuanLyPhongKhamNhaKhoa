using BLL.DAL.EF;
using DAL.DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationView.BLL.Manage
{
    public class MaterialService
    {

        public List<VatLieu> GetAll()
        {
            EFModels db = new EFModels();
            return db.VatLieux.ToList();
        }
        public VatLieu GetMaterial(int id)
        {
            EFModels db = new EFModels(); 
            return db.VatLieux.FirstOrDefault(p=>p.maVatLieu == id);   
        }

        public void AddMaterial(VatLieu vl)
        {
            EFModels db = new EFModels();
            db.VatLieux.Add(vl);
            db.SaveChanges();
        }

        public void EditMaterial(VatLieu vl)
        {
            EFModels db = new EFModels();
            db.VatLieux.AddOrUpdate(vl);
            db.SaveChanges();
        }

        public static void DeleteMaterial(int id)
        {
            EFModels db = new EFModels();
            db.NhapLieux.RemoveRange(db.NhapLieux.Where(p=>p.maVatLieu==id));
            db.VatLieux.Remove(db.VatLieux.FirstOrDefault(p=>p.maVatLieu == id));
            db.SaveChanges();
        }

        public long TotalMoney()
        {
            long sum = 0;
            EFModels databaseNhaKhoa = new EFModels();
            List<VatLieu> vl = GetAll();
            foreach (VatLieu vlItem in vl)
                sum += vlItem.thanhTien;
            return sum;
        }
    }
}
