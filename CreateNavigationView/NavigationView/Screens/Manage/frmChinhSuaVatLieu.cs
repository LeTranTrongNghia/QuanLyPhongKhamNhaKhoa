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
    public partial class frmChinhSuaVatLieu : Form
    {
        private readonly AccountService accountService = new AccountService();
        private readonly MaterialService materialService = new MaterialService();
        private readonly InputMaterialService inputMaterialService = new InputMaterialService();
        private readonly ExaminationHistory examinationHistory = new ExaminationHistory();
        private readonly BillService billService = new BillService();
        private readonly RevenueService revenueService = new RevenueService();

        private string maVatLieu;
        private string maNhanVien;
        private int soLuongBanDau;

        public frmChinhSuaVatLieu()
        {
            InitializeComponent();
        }
        public frmChinhSuaVatLieu(string maVatLieu)
        {
            InitializeComponent();
            this.maVatLieu = maVatLieu;
        }



        private void frmChinhSuaVatLieu_Load(object sender, EventArgs e)
        {
            VatLieu vatLieu = materialService.GetMaterial(int.Parse(this.maVatLieu));

            this.maNhanVien = accountService.GetTempInformation().maNhanVien.ToString();

            txtMaNhanVien.Text = this.maNhanVien;
            txtNgayNhap.Text = DateTime.Now.ToString("dd / MM / yyyy");

            txtMaVL.Text = this.maVatLieu;
            txtND.Text = vatLieu.noiDung;
            txtDVT.Text = vatLieu.dvt;
            txtDonGia.Text = String.Format("{0:n0}", vatLieu.donGia);
            txtSoLuongDau.Text = vatLieu.soLuong.ToString();

            this.soLuongBanDau = vatLieu.soLuong;
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
                frmKiemTraMatKhau kiemTra = new frmKiemTraMatKhau();
                kiemTra.ShowDialog();

                if (kiemTra.check == true)
                {
                    VatLieu vl = new VatLieu();

                    vl.maVatLieu = int.Parse(txtMaVL.Text);
                    vl.noiDung = txtND.Text;
                    vl.dvt = txtDVT.Text;
                    vl.soLuong = soLuongBanDau + (int)nudSoLuong.Value;
                    vl.donGia = int.Parse(txtDonGia.Text.Replace(",",""));
                    vl.thanhTien = vl.donGia * vl.soLuong;

                    //Luu lich su nhap lieu
                    NhapLieu nl = new NhapLieu()
                    {
                        ngay = DateTime.Now,
                        maNhanVien = int.Parse(txtMaNhanVien.Text),
                        maVatLieu = vl.maVatLieu,
                        soLuong = (int)nudSoLuong.Value,
                        donGia = vl.donGia,
                    };
                    nl.thanhTien = nl.donGia * nl.soLuong;

                    materialService.EditMaterial(vl);    
                    inputMaterialService.AddInputMaterial(nl);

                    DoanhThu dt = new DoanhThu()
                    {
                        ngay = DateTime.Now.Date,
                        soLuongKhachHang = examinationHistory.NumberOfPatientsByDay(DateTime.Now),
                        tienNhapLieu = inputMaterialService.LayTienNhapLieuTrongNgay(DateTime.Now.Date),
                        tienThuNhap = billService.LayTienThuNhapTrongNgay(DateTime.Now)
                    };
                    dt.loiNhuan = dt.tienThuNhap - dt.tienNhapLieu;
                    revenueService.AddRevenue(dt);

                    txtMaVL.Text = "";
                    txtND.Text = "";
                    txtDVT.Text = "";
                    nudSoLuong.Value = 0;
                    txtDonGia.Text = "";

                    MessageBox.Show("Thêm vật liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
