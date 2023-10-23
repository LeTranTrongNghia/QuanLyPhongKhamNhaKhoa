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
using NavigationView;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            //Lấy thông tin từ dữ liệu nhập vào
            string user = txtTaiKhoan.Text;
            string pass = txtMatKhau.Text;
            
            try
            {
                AccountService accountService = new AccountService();
                int quyenTruyCap = accountService.CheckAccountManager(user, pass);
                if (quyenTruyCap < 0)
                    throw new Exception("Tên Tài Khoản hoặc Mật Khẩu Không Đúng.");

                AccountService.taiKhoanDem = user;
                AccountService.matKhauDem = pass;

                FormTest home;
                if (chkLaQuanLy.Checked)
                    if(quyenTruyCap == 1)
                        home = new FormTest(0);
                    else
                        throw new Exception("Bạn Không Được Đăng Nhập Với Tư Cách QUẢN TRỊ VIÊN");
                else
                    home = new FormTest(quyenTruyCap);
                this.Hide();
                home.ShowDialog();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Show();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

            if(MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) 
                e.Cancel = true;
        }
    }
}
