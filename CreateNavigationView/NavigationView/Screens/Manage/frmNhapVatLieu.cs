using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NavigationView.BLL.Manage;
using BLL.DAL.EF;
using DAL.DAL.EF;

namespace NavigationView.Screens.Manage
{
    public partial class frmNhapVatLieu : Form
    {
        private readonly InputMaterialService input = new InputMaterialService();
        private readonly AccountService acc = new AccountService();
        private readonly MaterialService material = new MaterialService();  
        private readonly ExaminationHistory examinationHistory = new ExaminationHistory();
        private readonly BillService bill = new BillService();
        private readonly RevenueService revenue = new RevenueService(); 
        public frmNhapVatLieu()
        {
            InitializeComponent();
        }


        private bool KiemTraDungLaSoKhong(string id)
        {
            long a;
            return long.TryParse(id, out a);
        }

        private void frmNhapVatLieu_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = acc.GetTempInformation().maNhanVien.ToString();
            txtNgayNhap.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn không lưu?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtMaVL.Text == "" || txtND.Text == "" || txtDVT.Text == "" || txtDonGia.Text == "")
                    throw new Exception("Yêu cầu nhập đầy đủ thông tin");
                if (KiemTraDungLaSoKhong(txtMaVL.Text) == false)
                    throw new Exception("Yêu cầu nhập mã vật liệu bằng ký tự là số");
                if (KiemTraDungLaSoKhong(txtDonGia.Text) == false)
                    throw new Exception("Yêu cầu nhập đơn giá là số");
                if (material.GetMaterial(int.Parse(txtMaVL.Text)) != null)
                    throw new Exception("Đã có thông tin cho vật liệu này");


                frmKiemTraMatKhau kiemTra = new frmKiemTraMatKhau();
                kiemTra.ShowDialog();

                if(kiemTra.check == true)
                {
                    VatLieu vl = new VatLieu()
                    {
                        maVatLieu = int.Parse(txtMaVL.Text),
                        noiDung = txtND.Text,
                        dvt = txtDVT.Text,
                        soLuong = (int)nudSoLuong.Value,
                        donGia = int.Parse(txtDonGia.Text.Replace(",", "")),
                    };
                    vl.thanhTien = vl.donGia*vl.soLuong;

                    //Luu lich su nhap lieu
                    NhapLieu nl = new NhapLieu()
                    {
                        ngay = DateTime.Now,
                        maNhanVien = int.Parse(txtMaNhanVien.Text),
                        maVatLieu = vl.maVatLieu,
                        soLuong = vl.soLuong,
                        donGia = vl.donGia,
                        thanhTien=vl.thanhTien
                    };

                    

                    material.AddMaterial(vl);
                    input.AddInputMaterial(nl);

                    DoanhThu dt = new DoanhThu()
                    {
                        ngay = DateTime.Now,
                        soLuongKhachHang = examinationHistory.NumberOfPatientsByDay(DateTime.Now),
                        tienNhapLieu = input.LayTienNhapLieuTrongNgay(DateTime.Now),
                        tienThuNhap = bill.LayTienThuNhapTrongNgay(DateTime.Now)
                    };
                    dt.loiNhuan = dt.tienThuNhap - dt.tienNhapLieu;
                    revenue.AddRevenue(dt);
                    
                    txtMaVL.Text = "";
                    txtND.Text = "";
                    txtDVT.Text = "";
                    nudSoLuong.Value = 0;
                    txtDonGia.Text = "";

                    MessageBox.Show("Thêm vật liệu mới thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nhập sai mật khẩu", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
