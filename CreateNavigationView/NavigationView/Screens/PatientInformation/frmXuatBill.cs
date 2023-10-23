using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.DAL.EF;
using DAL.DAL.EF;

namespace NavigationView.Screens.PatientInformation
{
    public partial class frmXuatBill : Form
    {
        public frmXuatBill()
        {
            InitializeComponent();
        }
        private string patientID;
        EFModels pte=new EFModels();
        public frmXuatBill(string ma)
        {
            this.patientID = ma;
            InitializeComponent();
        }

        private void frmXuatBill_Load(object sender, EventArgs e)
        {
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                 txtSDT.Text = this.patientID;
                string patienSdt=txtSDT.Text;
                // tìm 1 mã bệnh nhân trùng với mã hóa đơn của bệnh nhân
                HoaDon invoice = pte.HoaDons.FirstOrDefault(p => p.ThongTinLamSan.ThongTinBenhNhan.soDienThoai == patienSdt);
                List<reportbill> lisreportbill = new List<reportbill>();
                if (invoice != null)
                {
                    reportbill reportbill = new reportbill();
                    reportbill.maChuanDoan = invoice.ThongTinLamSan.maChuanDoan;
                    reportbill.donViTinh = invoice.ThongTinLamSan.ChuanDoanDieuTri.donViTinh;
                    reportbill.noiDungChuanDoan = invoice.ThongTinLamSan.ChuanDoanDieuTri.noiDungChuanDoan;
                    reportbill.luaChonDieuTri = invoice.ThongTinLamSan.ChuanDoanDieuTri.luaChonDieuTri;
                    reportbill.soLuong = invoice.ThongTinLamSan.ChuanDoanDieuTri.soLuong;
                    reportbill.donGia = invoice.ThongTinLamSan.ChuanDoanDieuTri.donGia;
                    reportbill.thanhTien = invoice.ThongTinLamSan.ChuanDoanDieuTri.thanhTien;
                    reportbill.maBaoHanh = invoice.ThongTinLamSan.ChuanDoanDieuTri.maBaoHanh;
                    lisreportbill.Add(reportbill);
                    ReportParameter[] parameters = new ReportParameter[5];
                    parameters[4] = new ReportParameter("Ngaythangnam", string.Format("Ngày " + DateTime.Now.ToString("dd/MM/yyyy")));
                    parameters[0] = new ReportParameter("diachi", invoice.ThongTinCanLamSan.ThongTinBenhNhan.diaChi);
                    parameters[1] = new ReportParameter("hovaten", invoice.ThongTinCanLamSan.ThongTinBenhNhan.tenBenhNhan);
                    parameters[2] = new ReportParameter("mabenhnhan", invoice.ThongTinCanLamSan.ThongTinBenhNhan.maBenhNhan.ToString());
                    parameters[3] = new ReportParameter("sodienthoai", invoice.ThongTinCanLamSan.ThongTinBenhNhan.soDienThoai);
                    rpv_xuatbill.LocalReport.SetParameters(parameters);
                }
                else
                {
                    MessageBox.Show("Không có bệnh nhân");
                }
                this.rpv_xuatbill.LocalReport.ReportPath = "C:/Users/admin/OneDrive/Desktop/CreateNavigationView/NavigationView/Screens/PatientInformation/ReportBILL/rpBILL.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource("DataSetBILL", lisreportbill);
                rpv_xuatbill.LocalReport.DataSources.Clear();
                rpv_xuatbill.LocalReport.DataSources.Add(reportDataSource);

                this.rpv_xuatbill.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.rpv_xuatbill.RefreshReport();
        }
    }
}
