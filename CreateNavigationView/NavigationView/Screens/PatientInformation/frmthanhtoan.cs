using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

using BLL.DAL.EF;
using DAL.DAL.EF;

namespace NavigationView.Screens.PatientInformation
{
    public partial class frmthanhtoan : Form
    {
        
        EFModels pte = new EFModels();
   
        public frmthanhtoan()
        {
            InitializeComponent();
        }
        private string patientID;
        public frmthanhtoan(string ma)
        {
            this.patientID = ma;
            InitializeComponent();
        }

        private void FillpayCombobox(List<DichVuThanhToan> listpay)
        {
            this.cmbpttt.DataSource = listpay;
            this.cmbpttt.DisplayMember = "hinhThucThanhToan";
            this.cmbpttt.ValueMember = "maThanhToan";
        }
        private void frmthanhtoan_Load(object sender, EventArgs e)
        {
            List<DichVuThanhToan> listpay=pte.DichVuThanhToans.ToList();
            FillpayCombobox (listpay);
            txtsdt.Text = this.patientID;
            try
            {
                var mabn = txtsdt.Text;
                var patienthoadon = pte.HoaDons.FirstOrDefault(p => p.ThongTinLamSan.ThongTinBenhNhan.soDienThoai == mabn/* && p.ngayThanhToan== DateTime.Today.Date*/);
                if (patienthoadon != null)
                {

                    {
                        List<HoaDon> list = pte.HoaDons.Where(p => p.ThongTinLamSan.ThongTinBenhNhan.soDienThoai == mabn).ToList();
                        Bindinggrid(list);
                        txt_hoten.Text = patienthoadon.ThongTinCanLamSan.ThongTinBenhNhan.tenBenhNhan;
                        dtpnamsinh.Value = patienthoadon.ThongTinLamSan.ThongTinBenhNhan.namSinh.Date;
                        txt_diachi.Text = patienthoadon.ThongTinLamSan.ThongTinBenhNhan.diaChi;
                        txthuyetap.Text = patienthoadon.ThongTinCanLamSan.huyetAp.ToString();
                        if (patienthoadon.ThongTinCanLamSan.mauKhoDong == true)
                        {
                            rdbmau_co.Checked = true;
                        }
                        else if (patienthoadon.ThongTinCanLamSan.mauKhoDong == false)
                        {
                            rdbmau_khong.Checked = true;
                        }
                        if (patienthoadon.ThongTinCanLamSan.benhTimBamSinh == true)
                        {
                            rdbtim_co.Checked = true;
                        }
                        else if (patienthoadon.ThongTinCanLamSan.benhTimBamSinh == false)
                        {
                            rdb_timkhong.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Bindinggrid(List<HoaDon> listchuandoan)
        {
            dtgv_chuandoan.Rows.Clear();
            foreach (var item in listchuandoan)
            {
                int index = dtgv_chuandoan.Rows.Add();
                dtgv_chuandoan.Rows[index].Cells[0].Value = item.ThongTinLamSan.ChuanDoanDieuTri.noiDungChuanDoan;
                dtgv_chuandoan.Rows[index].Cells[1].Value = item.ThongTinLamSan.ChuanDoanDieuTri.luaChonDieuTri;
                dtgv_chuandoan.Rows[index].Cells[2].Value =item.ThongTinLamSan.ChuanDoanDieuTri.donViTinh;
                dtgv_chuandoan.Rows[index].Cells[3].Value = item.ThongTinLamSan.ChuanDoanDieuTri.soLuong;
                dtgv_chuandoan.Rows[index].Cells[4].Value = item.ThongTinLamSan.ChuanDoanDieuTri.donGia;
            }

        }

      
      

        

        private void btn_xuatbill_Click(object sender, EventArgs e)
        {
            frmXuatBill frmXuatBill = new frmXuatBill(txtsdt.Text);
            frmXuatBill.ShowDialog();
        }
    }
}
