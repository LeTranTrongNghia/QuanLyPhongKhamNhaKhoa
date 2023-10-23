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
using NavigationView.BLL.Manage;
using System.IO;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using DAL.DAL.EF;

namespace NavigationView.Screens.Manage
{
    public partial class frmStatics : UserControl
    {
        public frmStatics()
        {
            InitializeComponent();
        }


        private readonly BillService billService = new BillService();
        private readonly InputMaterialService inputMaterialService = new InputMaterialService();
        private readonly MaterialService materialService = new MaterialService();
        private readonly RevenueService revenueService = new RevenueService();
        private readonly StaffService staffService = new StaffService();



        #region Method

        //Format tien
        private string FormatMoney(int tien)
        {
            return String.Format("{0:n0}", tien);
        }
        //Thoát khỏi doanh thu
        private void thoatDoanhThu()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi doanh thu?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                ///
            }
        }

        //Lấy Thông Tin Nhân Viên
        private void LoadNhanVien(List<ThongTinNhanVien> nhanViens)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var nhanVien in nhanViens)
            {
                int index = dgvNhanVien.Rows.Add();
                DataGridViewRow row = dgvNhanVien.Rows[index];

                row.Cells[0].Value = nhanVien.maNhanVien;
                row.Cells[1].Value = nhanVien.hoVaTen;
                row.Cells[2].Value = (nhanVien.gioiTinh ? "Nữ" : "Nam");
                row.Cells[3].Value = nhanVien.namSinh.ToString("dd / MM/ yyyy");
                row.Cells[4].Value = nhanVien.soDienThoai;
                row.Cells[5].Value = nhanVien.diaChi;
                row.Cells[6].Value = nhanVien.ChucVu.tenChucVu;
                //dgvNhanVien.Rows.Add(row);
            }

        }

        //Lấy thông tin doanh thu
        private void LoadDoanhThu(List<DoanhThu> doanhThus)
        {
            doanhThus.Reverse();
            lvDoanhThu.Items.Clear();

            foreach (DoanhThu doanhThu in doanhThus)
            {
                ListViewItem listViewItem = new ListViewItem(doanhThu.ngay.ToString("dd / MM / yyyy"));
                listViewItem.SubItems.Add(doanhThu.soLuongKhachHang.ToString());
                listViewItem.SubItems.Add(FormatMoney(doanhThu.tienNhapLieu));
                listViewItem.SubItems.Add(FormatMoney(doanhThu.tienThuNhap));
                listViewItem.SubItems.Add(FormatMoney(doanhThu.loiNhuan));
                lvDoanhThu.Items.Add(listViewItem);
            }
        }
        //Lấy thông tin vật liệu
        private void LoadVatLieu(List<VatLieu> vatLieus)
        {
            dgvVatLieu.Rows.Clear();
            //List<VatLieu> vatLieus = materialService.GetAll();

            foreach (VatLieu vatLieu in vatLieus)
            {
                int index = dgvVatLieu.Rows.Add();
                DataGridViewRow row = dgvVatLieu.Rows[index];
                row.Cells[0].Value = vatLieu.maVatLieu;
                row.Cells[1].Value = vatLieu.noiDung;
                row.Cells[2].Value = vatLieu.dvt;
                row.Cells[3].Value = vatLieu.soLuong;
                row.Cells[4].Value = FormatMoney(vatLieu.donGia);
                row.Cells[5].Value = FormatMoney(vatLieu.thanhTien);
            }
            dgvVatLieu.Rows[dgvVatLieu.Rows.Count - 1].Cells[4].Value = "Tổng cộng";
            dgvVatLieu.Rows[dgvVatLieu.Rows.Count - 1].Cells[5].Value = materialService.TotalMoney().ToString("#,###");

        }

        //Lấy thông tin từ Hóa đơn để setup datagridview bảng doanh thu hóa đơn
        private void LoadHoaDon(List<HoaDon> hoaDonList)
        {
            hoaDonList.Reverse();
            dgvHoaDon.Rows.Clear();
            //List<HoaDon> hoaDonList = billService.GetAll();

            foreach (HoaDon hoaDon in hoaDonList)
            {
                int index = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[index].Cells[0].Value = hoaDon.maHoaDon;
                dgvHoaDon.Rows[index].Cells[1].Value = hoaDon.ThongTinCanLamSan.ThongTinBenhNhan.soDienThoai;
                dgvHoaDon.Rows[index].Cells[2].Value = hoaDon.ThongTinCanLamSan.ThongTinBenhNhan.tenBenhNhan;
                dgvHoaDon.Rows[index].Cells[3].Value = hoaDon.ngayThanhToan.ToString("dd / MM / yyyy");
                dgvHoaDon.Rows[index].Cells[4].Value = FormatMoney(hoaDon.tongSoTien);
                //tongHoaDon += hoaDon.tongSoTien;

            }
        }

        //Lấy thông tin từ nhập liệu để set up datagridview bảng thống kê nhập liệu

        private void LoadNhapLieu(List<NhapLieu> nhapLieuList)
        {
            nhapLieuList.Reverse();
            dgvNhapLieu.Rows.Clear();
            //List<NhapLieu> nhapLieuList = inputMaterialService.GetAll();
            foreach (NhapLieu nhapLieu in nhapLieuList)
            {
                int index = dgvNhapLieu.Rows.Add();
                //dgvNhapLieu.Rows[index].Cells[0].Value = nhapLieu.maNhap;
                dgvNhapLieu.Rows[index].Cells[0].Value = nhapLieu.maVatLieu;
                dgvNhapLieu.Rows[index].Cells[1].Value = nhapLieu.maNhanVien;
                dgvNhapLieu.Rows[index].Cells[2].Value = nhapLieu.ngay.ToString("dd / MM / yyyy");
                dgvNhapLieu.Rows[index].Cells[3].Value = nhapLieu.VatLieu.dvt;
                dgvNhapLieu.Rows[index].Cells[4].Value = nhapLieu.soLuong;
                dgvNhapLieu.Rows[index].Cells[5].Value = FormatMoney(nhapLieu.donGia);
                dgvNhapLieu.Rows[index].Cells[6].Value = FormatMoney(nhapLieu.thanhTien);

            }
        }



        //Nhập Liệu
        //Thêm vật liệu mới
        private void ThemMoi()
        {
            if (tabCtrlThongKe.SelectedTab == tabPageVL)
            {
                frmNhapVatLieu frmNhapVatLieu = new frmNhapVatLieu();
                frmNhapVatLieu.ShowDialog();
            }
            else if (tabCtrlThongKe.SelectedTab == tabQuanLyNhanVien)
            {
                frmNhanVien frmQuanLyNhanVien = new frmNhanVien();
                frmQuanLyNhanVien.ShowDialog();
            }
            else
            {
                MessageBox.Show("Trang này không được hỗ trợ thêm mới dữ liệu", "Thông Báo", MessageBoxButtons.OK);
            }

        }

        //Nhập vật liệu vào kho
        private void SuaDoi()
        {
            if (tabCtrlThongKe.SelectedTab == tabPageVL)
            {
                if (dgvVatLieu.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dgvVatLieu.SelectedRows[0];
                    string maVatLieu = dr.Cells[0].Value.ToString();
                    frmChinhSuaVatLieu frmChinhSuaVatLieu = new frmChinhSuaVatLieu(maVatLieu);
                    frmChinhSuaVatLieu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn chọn vật liệu cần thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else if (tabCtrlThongKe.SelectedTab == tabQuanLyNhanVien)
            {
                if (dgvVatLieu.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
                    int maNhanVien = int.Parse(dr.Cells[0].Value.ToString());
                    frmNhanVien frmQuanLyNhanVien = new frmNhanVien(maNhanVien);
                    frmQuanLyNhanVien.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn chọn nhân viên cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Trang này không hỗ trợ sửa đổi dữ liệu đang có", "Thông báo", MessageBoxButtons.OK);
            }
        }

        //Xóa vật liệu không còn sử dụng nữa
        private void Xoa()
        {
            if (tabCtrlThongKe.SelectedTab == tabPageVL)
            {
                frmKiemTraMatKhau frmKiemTraMatKhau = new frmKiemTraMatKhau();
                frmKiemTraMatKhau.ShowDialog();
                if (frmKiemTraMatKhau.check)
                {
                    int idDelete = int.Parse(dgvVatLieu.SelectedRows[0].Cells[0].Value.ToString());
                    MaterialService.DeleteMaterial(idDelete);
                    MessageBox.Show("Xóa vật liệu thành công", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (tabCtrlThongKe.SelectedTab == tabQuanLyNhanVien)
            {
                frmKiemTraMatKhau frmKiemTraMatKhau = new frmKiemTraMatKhau();
                frmKiemTraMatKhau.ShowDialog();
                if (frmKiemTraMatKhau.check)
                {
                    int idDelete = int.Parse(dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString());
                    AccountService.DeleteStaff(idDelete);
                    MessageBox.Show("Xóa vật liệu thành công", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Trang này không hỗ trợ cho việc tác vụ xóa dữ liệu", "Thông báo", MessageBoxButtons.OK);
            }
        }


        //Lọc thông tin (Còn đang chỉnh sửa)

        //Lọc hóa đơn theo mã hóa đơn, mã bệnh nhân, tên bệnh nhân, ngày hoàn tất hóa đơn
        private void LocHoaDon(string locStr)
        {
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (!row.IsNewRow)
                {
                    string maHoaDon = row.Cells[0].Value.ToString().ToLower();
                    string maBenhNhan = row.Cells[1].Value.ToString().ToLower();
                    string tenBenhNhan = row.Cells[2].Value.ToString().ToLower();
                    string ngay = row.Cells[3].Value.ToString().ToLower();

                    if (maHoaDon.Contains(locStr) || maBenhNhan.Contains(locStr) || tenBenhNhan.Contains(locStr) || ngay.Contains(locStr))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        //Lọc Lịch sử nhập liệu theo mã vật liệu, mã nhân viên, tên nhân viên, ngày nhập hàng
        private void LocLichSuNhapLieu(string locStr)
        {
            foreach (DataGridViewRow row in dgvNhapLieu.Rows)
            {
                if (!row.IsNewRow)
                {
                    // string maNhapLieu = row.Cells[0].Value.ToString().ToLower();
                    string maNhanVien = row.Cells[1].Value.ToString().ToLower();
                    string ngay = row.Cells[2].Value.ToString().ToLower();
                    string dvt = row.Cells[3].Value.ToString().ToLower();

                    if (maNhanVien.Contains(locStr) || ngay.Contains(locStr) || dvt.Contains(locStr))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        //Lọc thông tin vật liệu theo mã vật liệu, nội dung vật liệu và đơn vị tính
        private void LocVatLieu(string locStr)
        {
            foreach (DataGridViewRow row in dgvVatLieu.Rows)
            {

                if (!row.IsNewRow)
                {
                    string maVL = row.Cells[0].Value.ToString().ToLower();
                    string noiDung = row.Cells[1].Value.ToString().ToLower();
                    string dvt = row.Cells[2].Value.ToString().ToLower();
                    if (maVL.Contains(locStr) || noiDung.Contains(locStr) || dvt.Contains(locStr))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void LocNhanVien(string locStr)
        {
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {

                if (!row.IsNewRow)
                {
                    string maNV = row.Cells[0].Value.ToString().ToLower();
                    string hoTen = row.Cells[1].Value.ToString().ToLower();
                    string ngaySinh = row.Cells[3].Value.ToString().ToLower();
                    string soDienThoai = row.Cells[4].Value.ToString().ToLower();
                    string diaChi = row.Cells[5].Value.ToString().ToLower();
                    if (maNV.Contains(locStr) || hoTen.Contains(locStr) || ngaySinh.Contains(locStr) || soDienThoai.Contains(locStr) || diaChi.Contains(locStr))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        #endregion



        #region Event

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            //Load dữ liệu từ database lên
            List<NhapLieu> nhapLieuList = inputMaterialService.GetAll();
            List<HoaDon> hoaDonList = billService.GetAll();
            List<VatLieu> vatLieus = materialService.GetAll();
            List<DoanhThu> doanhThus = revenueService.GetAll();
            List<ThongTinNhanVien> nhanViens = staffService.GetAll();

            LoadDoanhThu(doanhThus);
            LoadHoaDon(hoaDonList);
            LoadNhapLieu(nhapLieuList);
            LoadVatLieu(vatLieus);
            LoadNhanVien(nhanViens);

            if (tabCtrlThongKe.SelectedTab == tabQuanLyNhanVien || tabCtrlThongKe.SelectedTab == tabPageVL)
            {
                tsBtnNam.Enabled = false;
                tsBtnQuy.Enabled = false;
                tsBtnThang.Enabled = false;
                tsBtnTatCa.Enabled = false;
            }
            else
            {
                tsBtnNam.Enabled = true;
                tsBtnQuy.Enabled = true;
                tsBtnThang.Enabled = true;
                tsBtnTatCa.Enabled = true;
            }

            //Hiển thị một số nội dung tổng quát ở thanh dưới
            tsDoanhThuNam.Text = "Tổng DT Năm: " + String.Format("{0:n0}", revenueService.GetTotalByYear()) + " VNĐ";
            tsDoanhThuThang.Text = "Tổng DT Tháng: " + String.Format("{0:n0}", revenueService.GetTotalByMonth()) + " VNĐ";
            tsDoanhThuQuy.Text = "Tổng DT Quý: " + String.Format("{0:n0}", revenueService.GetTotalByQuater()) + " VNĐ";

        }


        //Thoát chương trình lấy từ hàm chung thoatDoanhThu() để kế thừa

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thoatDoanhThu();
        }
        /*
        private void frmDoanhThu_FormClosed(object sender, FormClosedEventArgs e)
        {
            thoatDoanhThu();
        }
        */
        //Lọc dữ liệu thiếu lọc doanh thu
        private void tsTxtLoc_TextChanged(object sender, EventArgs e)
        {
            var tab = tabCtrlThongKe.SelectedTab;
            string locStr = tsTxtLoc.Text.ToLower();
            if (locStr != String.Empty)
            {

                if (tab == tabPageHD)
                    LocHoaDon(locStr);
                else if (tab == tabPageVL)
                    LocVatLieu(locStr);
                else if (tab == tabPageLSNL)
                    LocLichSuNhapLieu(locStr);
                else if (tab == tabQuanLyNhanVien)
                    LocNhanVien(locStr);

            }
            else
            {
                foreach (DataGridViewRow row in dgvNhapLieu.Rows)
                    row.Visible = true;
                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                    row.Visible = true;
                foreach (DataGridViewRow row in dgvVatLieu.Rows)
                    row.Visible = true;
                foreach (DataGridViewRow row in dgvNhanVien.Rows)
                    row.Visible = true;

            }

        }

        //Thêm vật liệu mới hoặc thêm nhân viên mới
        private void tsBtnThem_Click(object sender, EventArgs e)
        {
            ThemMoi();
            frmDoanhThu_Load(sender, e);
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemMoi();
            frmDoanhThu_Load(sender, e);
        }

        // Xóa vật liệu  hoặc xóa nhân viên
        private void tsBtnXoa_Click(object sender, EventArgs e)
        {
            Xoa();
            frmDoanhThu_Load(sender, e);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Xoa();
            frmDoanhThu_Load(sender, e);

        }

        //Nhập liệu vật liệu hoặc nhân viên
        private void tsBtnSua_Click(object sender, EventArgs e)
        {
            SuaDoi();
            frmDoanhThu_Load(sender, e);
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaDoi();
            frmDoanhThu_Load(sender, e);
        }
        //Sửa thông tin vật liệu khi double click vào 1 row của Bảng vật liệu
        private void dgvVatLieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SuaDoi();
            frmDoanhThu_Load(sender, e);
        }

        //Sửa thông tin nhân viên khi double click vào trang nhân viên

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SuaDoi();
            frmDoanhThu_Load(sender, e);
        }

        //Nếu như thay đổi formDoanhThu thì trả dữ liệu lại ban đầu
        private void tabCtrlThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsTxtLoc.Text = "";
            frmDoanhThu_Load(sender, e);
        }

        //Hiển thị bảng theo quý
        private void tsBtnQuy_Click(object sender, EventArgs e)
        {
            if (tabCtrlThongKe.SelectedTab == tabPageDT)
            {
                LoadDoanhThu(revenueService.GetByQuater());

            }
            else if (tabCtrlThongKe.SelectedTab == tabPageHD)
            {
                LoadHoaDon(billService.GetByQuater());
            }
            else if (tabCtrlThongKe.SelectedTab == tabPageLSNL)
            {
                LoadNhapLieu(inputMaterialService.GetByQuater());
            }
        }
        private void quýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsBtnQuy_Click(sender, e);
        }

        //Hiển thị bảng theo tháng
        private void tsBtnThang_Click(object sender, EventArgs e)
        {
            if (tabCtrlThongKe.SelectedTab == tabPageDT)
            {
                LoadDoanhThu(revenueService.GetByMonth());
            }
            else if (tabCtrlThongKe.SelectedTab == tabPageHD)
            {
                LoadHoaDon(billService.GetByMonth());
            }
            else if (tabCtrlThongKe.SelectedTab == tabPageLSNL)
            {
                LoadNhapLieu(inputMaterialService.GetByMonth());
            }
        }
        private void thángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsBtnThang_Click(sender, e);
        }

        //Hiển thị danh sách theo năm
        private void tsBtnNam_Click(object sender, EventArgs e)
        {
            if (tabCtrlThongKe.SelectedTab == tabPageDT)
            {
                LoadDoanhThu(revenueService.GetByYear());
            }
            else if (tabCtrlThongKe.SelectedTab == tabPageHD)
            {
                LoadHoaDon(billService.GetByYear());
            }
            else if (tabCtrlThongKe.SelectedTab == tabPageLSNL)
            {
                LoadNhapLieu(inputMaterialService.GetByYear());
            }
        }

        private void nămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsBtnNam_Click(sender, e);
        }


        //Hiển thị tất cả danh sách
        private void tsBtnTatCa_Click(object sender, EventArgs e)
        {
            if (tabCtrlThongKe.SelectedTab == tabPageDT)
            {
                LoadDoanhThu(revenueService.GetAll());
            }
            else if (tabCtrlThongKe.SelectedTab == tabPageHD)
            {
                LoadHoaDon(billService.GetAll());
            }
            else if (tabCtrlThongKe.SelectedTab == tabPageLSNL)
            {
                LoadNhapLieu(inputMaterialService.GetAll());
            }
        }

        private void tấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsBtnTatCa_Click(sender, e);
        }
        private void excelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            List<DoanhThu> doanhThus = revenueService.GetAll();
            List<HoaDon> hoaDons = billService.GetAll();
            List<VatLieu> vatLieus = materialService.GetAll();
            List<NhapLieu> nhapLieus = inputMaterialService.GetAll();


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Lưu văn bảng Excel";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;


                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheets = package.Workbook.Worksheets.Add("Thống Kê Doanh Thu");
                    worksheets.Cells["A1"].Value = "Ngày";
                    worksheets.Cells["B1"].Value = "Số lượng khách hàng";
                    worksheets.Cells["C1"].Value = "Tiền vật tư";
                    worksheets.Cells["D1"].Value = "Doanh số";
                    worksheets.Cells["E1"].Value = "Lợi nhuận";

                    int rowIndex = 2;

                    foreach (DoanhThu doanhThu in doanhThus)
                    {
                        worksheets.Cells["A" + rowIndex].Value = doanhThu.ngay;
                        worksheets.Cells["B" + rowIndex].Value = doanhThu.soLuongKhachHang;
                        worksheets.Cells["C" + rowIndex].Value = FormatMoney(doanhThu.tienNhapLieu);
                        worksheets.Cells["D" + rowIndex].Value = FormatMoney(doanhThu.tienThuNhap);
                        worksheets.Cells["E" + rowIndex].Value = FormatMoney(doanhThu.loiNhuan);
                        rowIndex++;
                    }

                    rowIndex = 2;
                    ExcelWorksheet worksheet1 = package.Workbook.Worksheets.Add("Thống Kê Hóa Đơn");
                    worksheet1.Cells["A1"].Value = "Mã Hóa Đơn";
                    worksheet1.Cells["B1"].Value = "Ngày Thanh Toán";
                    worksheet1.Cells["C1"].Value = "Số Điện Thoại";
                    worksheet1.Cells["D1"].Value = "Tên Bệnh Nhân";
                    worksheet1.Cells["E1"].Value = "Hình thức thanh toán";
                    worksheet1.Cells["F1"].Value = "Tổng số tiền";

                    foreach (HoaDon hoaDon in hoaDons)
                    {
                        worksheet1.Cells["A" + rowIndex].Value = hoaDon.maHoaDon;
                        worksheet1.Cells["B" + rowIndex].Value = hoaDon.ngayThanhToan.ToString("dd / MM/ yyyy");
                        worksheet1.Cells["C" + rowIndex].Value = hoaDon.ThongTinCanLamSan.ThongTinBenhNhan.soDienThoai;
                        worksheet1.Cells["D" + rowIndex].Value = hoaDon.ThongTinCanLamSan.ThongTinBenhNhan.tenBenhNhan;
                        worksheet1.Cells["E" + rowIndex].Value = hoaDon.DichVuThanhToan.hinhThucThanhToan;
                        worksheet1.Cells["F" + rowIndex].Value = FormatMoney(hoaDon.tongSoTien);
                        rowIndex++;
                    }

                    rowIndex = 2;
                    ExcelWorksheet worksheet2 = package.Workbook.Worksheets.Add("Thống Kê Vật Liệu");
                    worksheet2.Cells["A1"].Value = "Mã Vật Liệu";
                    worksheet2.Cells["B1"].Value = "Nội Dung";
                    worksheet2.Cells["C1"].Value = "Đơn Vị Tính";
                    worksheet2.Cells["D1"].Value = "Số Lượng";
                    worksheet2.Cells["E1"].Value = "Đơn Giá";
                    worksheet2.Cells["F1"].Value = "Thành Tiền";

                    foreach (VatLieu vatLieu in vatLieus)
                    {
                        worksheet2.Cells["A" + rowIndex].Value = vatLieu.maVatLieu;
                        worksheet2.Cells["B" + rowIndex].Value = vatLieu.noiDung;
                        worksheet2.Cells["C" + rowIndex].Value = vatLieu.dvt;
                        worksheet2.Cells["D" + rowIndex].Value = vatLieu.soLuong;
                        worksheet2.Cells["E" + rowIndex].Value = FormatMoney(vatLieu.donGia);
                        worksheet2.Cells["F" + rowIndex].Value = FormatMoney(vatLieu.thanhTien);
                        rowIndex++;
                    }

                    rowIndex = 2;
                    ExcelWorksheet worksheet3 = package.Workbook.Worksheets.Add("Lịch Sử Nhập Liệu");
                    worksheet3.Cells["A1"].Value = "Mã Nhập Liệu";
                    worksheet3.Cells["B1"].Value = "Mã Nhân Viên";
                    worksheet3.Cells["C1"].Value = "Ngày Nhập";
                    worksheet3.Cells["D1"].Value = "Mã Vật Liệu";
                    worksheet3.Cells["E1"].Value = "Tên Vật Liệu";
                    worksheet3.Cells["F1"].Value = "Đơn Vị Tính";
                    worksheet3.Cells["G1"].Value = "Số lượng";
                    worksheet3.Cells["H1"].Value = "Đơn giá";
                    worksheet3.Cells["I1"].Value = "Thành Tiền";

                    foreach (NhapLieu nhapLieu in nhapLieus)
                    {
                        worksheet3.Cells["A" + rowIndex].Value = nhapLieu.maNhap;
                        worksheet3.Cells["B" + rowIndex].Value = nhapLieu.maNhanVien;
                        worksheet3.Cells["C" + rowIndex].Value = nhapLieu.ngay.ToString("dd / MM / yyyy");
                        worksheet3.Cells["D" + rowIndex].Value = nhapLieu.maVatLieu;
                        worksheet3.Cells["E" + rowIndex].Value = nhapLieu.VatLieu.noiDung;
                        worksheet3.Cells["F" + rowIndex].Value = nhapLieu.VatLieu.dvt;
                        worksheet3.Cells["G" + rowIndex].Value = nhapLieu.soLuong;
                        worksheet3.Cells["H" + rowIndex].Value = FormatMoney(nhapLieu.donGia);
                        worksheet3.Cells["I" + rowIndex].Value = FormatMoney(nhapLieu.thanhTien);
                        rowIndex++;
                    }
                    FileInfo fileInfo = new FileInfo(filePath);
                    package.SaveAs(fileInfo);
                    MessageBox.Show("Xuất File Excel thành công:\n" + filePath);
                }
            }
        }

        //Xuất Messbox thông tin nhân viên đã nhập hàng

        private void dgvNhapLieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int maNhanVien = int.Parse(dgvNhapLieu.SelectedRows[0].Cells[1].Value.ToString());
            ThongTinNhanVien nhanVien = staffService.GetStaff(maNhanVien);
            MessageBox.Show("Thông tin nhân viên đã nhập hàng:\n - " + nhanVien.maNhanVien.ToString() + "\n - " + nhanVien.hoVaTen + " - " + nhanVien.soDienThoai + " - " + nhanVien.ChucVu.tenChucVu, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


    }

}
