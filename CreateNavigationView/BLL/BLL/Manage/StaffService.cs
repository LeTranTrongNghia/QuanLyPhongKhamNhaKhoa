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
    public class StaffService
    {
        public List<ThongTinNhanVien> GetAll()
        {
            EFModels db  =new EFModels();
            return db.ThongTinNhanViens.ToList();
        }

        public ThongTinNhanVien GetStaff(int id)
        {
            return GetAll().FirstOrDefault(p=>p.maNhanVien == id);
        }

        public ThongTinNhanVien GetStaffByNumberPhone(string sdt)
        {
            return GetAll().FirstOrDefault(p => p.soDienThoai.Equals(sdt));
        }

        public int Add(ThongTinNhanVien nhanVien)
        {
            EFModels db = new EFModels();
            db.ThongTinNhanViens.Add(nhanVien);
            db.SaveChanges();
            return GetStaffByNumberPhone(nhanVien.soDienThoai).maNhanVien;
        }

        public void Update(ThongTinNhanVien nhanVien)
        {
            EFModels db = new EFModels();
            db.ThongTinNhanViens.AddOrUpdate(nhanVien);
            db.SaveChanges();
        }

    }
}
