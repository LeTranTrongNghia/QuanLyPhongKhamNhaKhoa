using NavigationView.BLL.Manage;
using BLL.DAL.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DAL.EF;

namespace NavigationView.Screens.Manage
{
    public partial class frmNhanVien : Form
    {


        private static readonly FunctionService functionService = new FunctionService();
        private static readonly StaffService staffService = new StaffService();
        private static readonly AccountService accountService = new AccountService();
        private int maNhanVien = 0;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        public frmNhanVien(int maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;
        }


        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "")
            {
                radNam.Enabled = true;
                radNu.Enabled = true;
                dtpNgaySinh.Enabled = true;
                txtSoDienThoai.Enabled = true;
            }
            else
            {
                radNam.Enabled = false;
                radNu.Enabled = false;
                dtpNgaySinh.Enabled = false;
                txtSoDienThoai.Enabled = false;
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text != "")
            {
                txtDiaChis.Enabled = true;
            }
            else
            {
                txtDiaChis.Enabled = false;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChis.Text != "")
            {
                txtTaiKhoan.Enabled = true;
                cmbChucVus.Enabled = true;
            }
            else
            {
                txtTaiKhoan.Enabled = false;
                cmbChucVus.Enabled = false;
            }
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "")
            {
                txtMatKhau.Enabled = true;
                chkSeen.Enabled = true;
            }
            else
            {
                txtMatKhau.Enabled = false;
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != "")
            {
                txtNhapLaiMatKhau.Enabled = true;
            }
            else
            {
                txtNhapLaiMatKhau.Enabled = false;
            }
        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapLaiMatKhau.Text != "")
            {
                btnLuu.Enabled = true;
            }
            else
            {
                btnLuu.Enabled = false;
            }
        }



        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự không muốn lưu?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FillChucVu(List<ChucVu> chucVus)
        {
            cmbChucVus.DataSource = chucVus;
            cmbChucVus.DisplayMember = "tenChucVu";
            cmbChucVus.ValueMember = "maChucVu";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            List<ChucVu> chucVus = functionService.GetAll();

            radNam.Checked = true;
            FillChucVu(chucVus);



            if (maNhanVien != 0)
            {
                ThongTinNhanVien nhanVien = staffService.GetStaff(maNhanVien);
                txtHoTen.Text = nhanVien.hoVaTen;
                radNu.Checked = nhanVien.gioiTinh;
                dtpNgaySinh.Value = nhanVien.namSinh;
                txtSoDienThoai.Text = nhanVien.soDienThoai;
                txtDiaChis.Text = nhanVien.diaChi;
                cmbChucVus.SelectedValue = nhanVien.maChucVu;
                TaiKhoan taiKhoan = accountService.GetTempInformation(nhanVien.maNhanVien);
                txtTaiKhoan.Text = taiKhoan.taiKhoanNhanVien;
            }
        }

        private void chkSeen_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkSeen.Checked;
            txtNhapLaiMatKhau.UseSystemPasswordChar = !chkSeen.Checked;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtSoDienThoai.Text.Trim();
                if(a.Length < 8 || a.Length > 12 || a.All(char.IsDigit) == false)
                {
                    throw new Exception("Số điện thoại không đúng định dạng");
                }
                if (!txtMatKhau.Text.Equals(txtNhapLaiMatKhau.Text))
                    throw new Exception("Mật khẩu không trùng nhau");
                
                ThongTinNhanVien nhanVien = new ThongTinNhanVien()
                {
                    hoVaTen = txtHoTen.Text,
                    gioiTinh = radNu.Checked?true:false,
                    namSinh = DateTime.Parse(dtpNgaySinh.Value.ToString("yyyy-MM-dd")),
                    soDienThoai = txtSoDienThoai.Text,
                    diaChi = txtDiaChis.Text,
                    maChucVu = (int)cmbChucVus.SelectedValue
                };

                TaiKhoan taiKhoan = new TaiKhoan()
                {
                    taiKhoanNhanVien = txtTaiKhoan.Text,
                    matKhauNhanVien = txtMatKhau.Text
                };

                //Kiểm tra xem số điện thoại có trùng với dưới duwxc liệu hay không
                ThongTinNhanVien nhanVienTemp = staffService.GetStaffByNumberPhone(nhanVien.soDienThoai);
                if ( nhanVienTemp!= null)
                {
                    //Nếu có thì hiện thông báo cho người dùng có cần cập nhật lại thông tin đó không
                    DialogResult result =  MessageBox.Show("Đã có thông tin nhân viên cho số điện thoại " + nhanVien.soDienThoai + "\nBạn có muốn sửa đổi không?", "Thông báo" ,MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        //Nếu người dùng đồng ý cập nhật thì cập nhật lại thông tin nhân viên và tài khoản nhân viên
                        nhanVien.maNhanVien = nhanVienTemp.maNhanVien;
                        staffService.Update(nhanVien);
                        //kiểm tra nhân viên đó có tài khoản chưa
                        TaiKhoan taiKhoanTemp = accountService.GetTempInformation(nhanVien.maNhanVien);
                        if(taiKhoanTemp!= null)
                        {
                            //Kiểm tra nếu có tài khoản rồi thì kiểm tra tiếp tài khoản có đúng chưa
                            if (taiKhoanTemp.taiKhoanNhanVien.Equals(taiKhoan.taiKhoanNhanVien))
                            {
                                //Nếu tài khoản đúng thì cập nhật mật khẩu nhân viên
                                taiKhoan.maNhanVien = taiKhoanTemp.maNhanVien;
                                accountService.Update(taiKhoan);
                                MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                                this.Close();
                            }
                            else
                            {
                                //Nếu không thì báo tên tài khoản không đúng không thể cập nhật mật khẩu
                                MessageBox.Show("Tên tài khoản không đúng không thể cập nhật mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //Kiểm tra chưa có tài khoản thì kiểm tài khoản đã được sử dụng chưa
                            //Nếu có kêu tên tài khoản đã có
                            //Nếu chưa tạo tài khoản cho nhân viên đó
                            taiKhoan.maNhanVien = nhanVien.maNhanVien;
                            accountService.Update(taiKhoan);
                            MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                            this.Close();
                        }

                        
                    }
                    //Nếu người dùng không đồng ý thì không lưu gì cả
                }
                else
                {
                    //Không có thông tin người dùng trong tài khoản
                    //Tạo thông tin nhân viên mới
                    int maNhanVien = staffService.Add(nhanVien);
                    //Kiểm tra tài khoản đã có chưa nếu có rồi thì báo đã có tài khoản
                    TaiKhoan taiKhoanTemp = accountService.GetTempInformation(taiKhoan.taiKhoanNhanVien);
                    if (taiKhoanTemp != null)
                    {
                        MessageBox.Show("Tên tài khoản đã có người sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Nếu không tài khoản chưa có thì add tài khoản
                    else
                    {
                        taiKhoan.maNhanVien = maNhanVien;
                        accountService.Update(taiKhoan);
                    }
                    //Thông báo tạo tài khoản thành công
                    MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
