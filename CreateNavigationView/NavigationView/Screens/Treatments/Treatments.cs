using System;
using System.Windows.Forms;
using BLL.DAL.EF;
using DAL.DAL.EF;
using NavigationView.BLL.Treatments;
using BLL.BLL.Treatments;
using System.Collections.Generic;
using NavigationView.BLL.Manage;

namespace NavigationView.UserControls
{
    public partial class UserControl3 : UserControl
    {
        private readonly ThongtincanlamsanService thongtincanlamsanService = new ThongtincanlamsanService();
        private readonly AccountService accountService = new AccountService();
        private readonly ThongtinlamsanService thongtinlamsanService = new ThongtinlamsanService();
        private readonly ChuandoandieutriService chuandoandieutriService = new ChuandoandieutriService();
        private readonly HoadonService hoadonService = new HoadonService();
        private readonly LichsukhamService lichsukhamService = new LichsukhamService();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmabenhnhanform1.Text != "")
                {
                    ThongTinCanLamSan cls = new ThongTinCanLamSan()
                    {
                        maBenhNhan = thongtincanlamsanService.finfID(txtmabenhnhanform1.Text),
                        huyetAp = int.Parse(txthuyetap.Text),
                        khac = txtkhac.Text
                    };

                    if (btnmau1.Checked == true)
                        cls.mauKhoDong = true;
                    if (btnmau2.Checked == true)
                        cls.mauKhoDong = false;
                    if (btntim1.Checked == true)
                        cls.benhTimBamSinh = true;
                    if (btntim2.Checked == true)
                        cls.benhTimBamSinh = false;
                    if (btntri1.Checked == true)
                        cls.thieuNangTriTue = true;
                    if (btntri2.Checked == true)
                        cls.thieuNangTriTue = false;

                    if (thongtincanlamsanService.Add_Update(cls) != 0)
                    {
                        MessageBox.Show("Lưu trữ thông tin cận lâm sàng vừa nhập thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập mã bệnh nhân.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            panel_LS.Visible = true;
            panel_LS.BringToFront();
            txtmabenhnhanform2.Text = txtmabenhnhanform1.Text;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (txtmabenhnhanform1.Text != "")
            {
                string sdt = txtmabenhnhanform1.Text;
                var item = thongtincanlamsanService.Find(sdt);

                if (item != null)
                {
                    txthuyetap.Text = item.huyetAp.ToString();
                    txtkhac.Text = item.khac;

                    if (item.mauKhoDong == true)
                        btnmau1.Checked = true;
                    if (item.mauKhoDong == false)
                        btnmau2.Checked = true;

                    if (item.benhTimBamSinh == true)
                        btntim1.Checked = true;
                    if (item.benhTimBamSinh == false)
                        btntim2.Checked = true;

                    if (item.thieuNangTriTue == true)
                        btntri1.Checked = true;
                    if (item.thieuNangTriTue == false)
                        btntri2.Checked = true;

                }
                else
                {
                    MessageBox.Show("Không có hồ sơ thông tin này");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập mã bệnh nhân để tiếp tục!");
            }
        }

        private void btntruoc_Click(object sender, EventArgs e)
        {
            panel_LS.Visible = false;
            panel_CLS.BringToFront();
        }

        public void filldata(int a)
        {
            var chuandoan_dieutri = chuandoandieutriService.getNDdieutri(a);

            foreach (var item in chuandoan_dieutri)
            {
                int index = dtgvNDdieutri.Rows.Add();
                dtgvNDdieutri.Rows[index].Cells[0].Value = item.noiDungChuanDoan;
                dtgvNDdieutri.Rows[index].Cells[1].Value = item.luaChonDieuTri;
                dtgvNDdieutri.Rows[index].Cells[2].Value = item.donViTinh;
                dtgvNDdieutri.Rows[index].Cells[3].Value = item.soLuong;
                dtgvNDdieutri.Rows[index].Cells[4].Value = item.donGia;
                dtgvNDdieutri.Rows[index].Cells[5].Value = item.thanhTien;
            }
        }
        private void frmLS_Load(object sender, EventArgs e)
        {
            var listChuandoan = chuandoandieutriService.getall();
            listChuandoan.Insert(0, new ChuanDoanDieuTri());
            this.cmbchuandoan.DataSource = listChuandoan;
            this.cmbchuandoan.DisplayMember = "noiDungChuanDoan";
            this.cmbchuandoan.ValueMember = "maChuanDoan";
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            filldata(int.Parse(cmbchuandoan.SelectedValue.ToString()));
            MessageBox.Show("Lưu trữ thông tin vừa nhập thành công");
        }

        private void cmbchuandoan_TextChanged(object sender, EventArgs e)
        {
            if (cmbchuandoan.Text == "")
            {
                txtdieutri.Text = "";
            }
            else
            {

                if (int.TryParse(cmbchuandoan.SelectedValue?.ToString(), out int macd))//chuyển đổi giá trị được chọn từ ComboBox cmbMachuandoan thành một số nguyên và gán kết quả vào biến macd
                //nếu SelectedValue == null thì trả về int macd = null
                // out int macd : Khi int.TryParse thành công và chuyển đổi chuỗi thành một số nguyên, giá trị số nguyên đó sẽ được gán vào biến macd.
                {
                    txtdieutri.Text = thongtinlamsanService.noidungdieutri(macd);
                }
            }
        }

        private void dtgvNDdieutri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvNDdieutri.RowCount > 1) // ktra datagridview có dữ liệu hay không ( 1 là do cái datagridview luôn có 1 hàng rỗng, có thể tắt o
            {
                if (dtgvNDdieutri.SelectedRows.Count == 0)
                {
                    btnXoa.Enabled = false;
                    return;
                }
                else
                {
                    DataGridViewRow row = dtgvNDdieutri.SelectedRows[0];
                    if (row.Cells[dtgvNDdieutri.Columns[0].Index].Value?.ToString() == null)
                    {
                        MessageBox.Show("Hãy chọn nội dung điều trị!");
                        btnXoa.Enabled = false;
                    }
                    else
                    {
                        btnXoa.Enabled = true;
                        cmbchuandoan.Text = row.Cells[dtgvNDdieutri.Columns[0].Index].Value.ToString();

                    }

                }

            }
            else
            {
                btnXoa.Enabled = false;
                MessageBox.Show("Không tồn tại thông tin điều trị");

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvNDdieutri.SelectedRows.Count > 0)
            {
                int selectedIndex = dtgvNDdieutri.SelectedRows[0].Index;
                dtgvNDdieutri.Rows.RemoveAt(selectedIndex);

                dtgvNDdieutri.Update();
                if (dtgvNDdieutri.RowCount == 1)
                {
                    btnXoa.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thông tin điều trị cần xóa");
            }
        }

        private void btnHoanthanh_Click(object sender, EventArgs e)
        {
            try
            {

                int dem = 0;
                foreach (DataGridViewRow row in dtgvNDdieutri.Rows)
                {
                    var value = row.Cells[0].Value;
                    if (value != null)
                    {
                        int ma = chuandoandieutriService.maChuandoan(value.ToString());
                        ThongTinLamSan thongtin = new ThongTinLamSan()
                        {
                            maBenhNhan = thongtincanlamsanService.finfID(txtmabenhnhanform2.Text),
                            maChuanDoan = ma,
                        };
                        if (thongtinlamsanService.Add_Update(thongtin) == 1)
                        {
                            dem++;
                        }
                    }
                }
                if (dem == dtgvNDdieutri.RowCount - 1)
                {
                    int macanlamsan = 0;


                    //hóa đơn
                    var item = thongtinlamsanService.getThongtinbenh(thongtincanlamsanService.finfID(txtmabenhnhanform2.Text));//trả về thông tin lâm sàn có mbn --> list thông tin lâm sàn
                    if (thongtincanlamsanService.macanlamsan(thongtincanlamsanService.finfID(txtmabenhnhanform2.Text)) != 0)//ktra và lưu giá trị mã cận lâm sàn tương ứng
                    {
                        macanlamsan = thongtincanlamsanService.macanlamsan(thongtincanlamsanService.finfID(txtmabenhnhanform2.Text));
                    }
                    //add hóa đơn
                    int dem1 = 0;

                    foreach (var i in item)
                    {

                        HoaDon h = new HoaDon()
                        {
                            ngayThanhToan = DateTime.Today.Date,
                            maThanhToan = 1,
                            maDonThuoc = 1,
                            maLamSan = i.maLamSan,
                            maCanLamSan = macanlamsan,
                            maBenhNhan = i.maBenhNhan,
                            tongSoTien = int.Parse(chuandoandieutriService.Tien(i.maLamSan)),

                        };

                        if (hoadonService.Addhd(h) == 1)
                        {
                            dem1++;
                        }

                    }

                    if (dem1 == item.Count)
                    {
                        try
                        {
                            MessageBox.Show("Lưu thành công");
                            List<HoaDon> hoadoncuabenhnhan = new List<HoaDon>(); // list hóa đơn của bệnh nhân trong lần khám 
                            var listhoadon = hoadonService.Hoadoncuabenhnhan(thongtincanlamsanService.finfID(txtmabenhnhanform2.Text));
                            foreach (var i in listhoadon)
                            {

                                LichSuKham lsk = new LichSuKham()
                                {
                                    ngayKham = i.ngayThanhToan,
                                    maHoaDon = i.maHoaDon,
                                    maBenhNhan = i.maBenhNhan,
                                    maNhanVien = accountService.GetTempInformation().maNhanVien
                                };

                                if (lsk.ngayKham == null)
                                {
                                    MessageBox.Show("lsk rỗng");
                                }
                                else
                                {

                                    lichsukhamService.Addlsk(lsk);
                                    dem1++;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lưu không thành công");
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}