using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using BLL.DAL.EF;
using DAL.DAL.EF;

namespace NavigationView.Screens.PatientInformation
{
    public partial class frmthembenhnhan : Form
    {
        EFModels pte = new EFModels();
        public ThongTinBenhNhan UpdatedPatient { get; private set; }
        public bool IsDataSaved { get; private set; }
        public frmthembenhnhan()
        {
            InitializeComponent();
        }
        private string sodienthoai;
        public frmthembenhnhan(string sodienthoai)
        {
            this.sodienthoai=sodienthoai;
            InitializeComponent();
        }

        private void txthoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
       
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txthoten.Text == ""|| txt_lido.Text == "" || txt_sdt.Text == "") 
                    throw new Exception("Vui lòng nhập đầy đủ thông tin của bệnh nhân.");
                if(pte.ThongTinBenhNhans.Any(p=>p.soDienThoai== txt_sdt.Text))
                    throw new Exception("Số điện thoại đã có trong data");
                ThongTinBenhNhan newpatient = new ThongTinBenhNhan();
                newpatient.tenBenhNhan = txthoten.Text;
                newpatient.namSinh=dtp_namsinh.Value.Date;
                newpatient.gioiTinh = rdb_nam.Checked ? true : false;
                newpatient.soDienThoai=txt_sdt.Text;
                newpatient.diaChi = txtdiachi.Text;
                newpatient.ngayKhamDauTien = dtp_ngaykham.Value.Date;
                newpatient.lyDoDenKham = txt_lido.Text;
                pte.ThongTinBenhNhans.AddOrUpdate(newpatient);
                pte.SaveChanges();
            
                MessageBox.Show("them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)

        {
           Close();
        }
        
        private void btnsua_Click(object sender, EventArgs e)
        {
            ThongTinBenhNhan updatepatient = pte.ThongTinBenhNhans.FirstOrDefault(p => p.soDienThoai == txt_sdt.Text);
            System.Media.SystemSounds.Exclamation.Play();
            if (updatepatient != null)
            {
                updatepatient.tenBenhNhan = txthoten.Text;
                updatepatient.namSinh = dtp_namsinh.Value.Date;
                updatepatient.gioiTinh = rdb_nam.Checked ? true : false;
                updatepatient.diaChi = txtdiachi.Text;
                updatepatient.ngayKhamDauTien = dtp_ngaykham.Value.Date;
                updatepatient.lyDoDenKham = txt_lido.Text;
                pte.ThongTinBenhNhans.AddOrUpdate(updatepatient);
                pte.SaveChanges();
                MessageBox.Show($"Sửa bệnh nhân {updatepatient.tenBenhNhan} thành công", "thông báo", MessageBoxButtons.OK);
                UpdatedPatient = updatepatient; // Gán giá trị cho biến UpdatedPatient
                IsDataSaved = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tim thấy bệnh nhân cần sửa");
            }
            
        }

        private void thembenhnhan_Load(object sender, EventArgs e)
        {
            ThongTinBenhNhan patient= pte.ThongTinBenhNhans.FirstOrDefault(p=>p.soDienThoai==this.sodienthoai);
            if (patient!=null)
            {
                txt_sdt.Text = this.sodienthoai;
                txthoten.Text = patient.tenBenhNhan.ToString();
                dtp_namsinh.Value = patient.namSinh.Date;
                rdb_nam.Checked = patient.gioiTinh;
                rdb_nu.Checked = patient.gioiTinh;
                txtdiachi.Text = patient.diaChi;
                dtp_ngaykham.Value = patient.ngayKhamDauTien.Date;
                txt_lido.Text = patient.lyDoDenKham;
            }
        }
 
    }
}
