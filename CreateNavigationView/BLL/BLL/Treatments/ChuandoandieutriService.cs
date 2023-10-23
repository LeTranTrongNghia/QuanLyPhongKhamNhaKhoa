using BLL.DAL.EF;
using DAL.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Treatments
{
    public class ChuandoandieutriService
    {
        public List<ChuanDoanDieuTri> getall()
        {
            EFModels context = new EFModels();
            return context.ChuanDoanDieuTris.ToList();
        }
        public List<ChuanDoanDieuTri> getNDdieutri(int mcd)
        {
            EFModels context = new EFModels();
            return context.ChuanDoanDieuTris.Where(p => p.maChuanDoan == mcd).ToList();
        }

        public int maChuandoan(string noidung)
        {
            EFModels context = new EFModels();
            return int.Parse(context.ChuanDoanDieuTris.FirstOrDefault(p => p.noiDungChuanDoan == noidung).maChuanDoan.ToString());
        }

        public string Tien(int mals)
        {
            EFModels context = new EFModels();
            var item = context.ThongTinLamSans.FirstOrDefault(p => p.maLamSan == mals).maChuanDoan;
            return context.ChuanDoanDieuTris.FirstOrDefault(p => p.maChuanDoan == item).thanhTien.ToString();
        }
    }
}
