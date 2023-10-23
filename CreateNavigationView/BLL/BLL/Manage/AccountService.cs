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
    public class AccountService
    {
        public static string taiKhoanDem ="";
        public static string matKhauDem = "";

        //Kiểm tra có đúng là nhân viên quản lý hay không?
        public int CheckAccountManager(string user, string password)
        {
            EFModels database = new EFModels();
            TaiKhoan account = database.TaiKhoans.FirstOrDefault(p => p.taiKhoanNhanVien == user && p.matKhauNhanVien == password);
            if (account == null)
                return -1;
            return account.ThongTinNhanVien.maChucVu;
        }

        //Lấy thông tin tài khoản nhân viên từ bộ nhớ đệm
        public TaiKhoan GetTempInformation()
        {
            EFModels db = new EFModels();
            return db.TaiKhoans.FirstOrDefault(p=>p.taiKhoanNhanVien == taiKhoanDem && p.matKhauNhanVien == matKhauDem);
        }

        public TaiKhoan GetTempInformation(int id)
        {
            EFModels db = new EFModels();
            return db.TaiKhoans.FirstOrDefault(p => p.maNhanVien == id);
        }

        public TaiKhoan GetTempInformation(string taiKhoan)
        {
            EFModels db = new EFModels();
            return db.TaiKhoans.FirstOrDefault(p => p.taiKhoanNhanVien.Equals(taiKhoan));
        }

        //Khi Quản Trị Viên Muốn Xóa Nhân Viên Thì Vẫn Giữ Nguyên Thông Tin Nhân Viên và Chỉ xóa Thông tin account
        //Để tránh việc mất thông tin khám bệnh, nhập liệu khi nhân viên đó không còn làm ở phòng khám nữa
        //Đồng thời tránh việc khách hàng khiếu nại nhưng không có thông tin để tra cứu
        public static void DeleteStaff(int id)
        {

            EFModels db = new EFModels();
            TaiKhoan tk = db.TaiKhoans.FirstOrDefault(p=>p.maNhanVien==id);
            db.TaiKhoans.Remove(tk);
            db.SaveChanges();
        }

        public bool Update(TaiKhoan acc)
        {

            EFModels db = new EFModels();
            db.TaiKhoans.AddOrUpdate(acc);
            db.SaveChanges();
            return true;
  
            //return false;
        }
    }
}
