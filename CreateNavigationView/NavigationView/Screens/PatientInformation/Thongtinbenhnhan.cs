using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL.DAL.EF;
using DAL.DAL.EF;
//using ThonTinBenhNhan.model;

namespace NavigationView.Screens.PatientInformation
{
    public partial class Thongtinbenhnhan : UserControl
    {
        private static Thongtinbenhnhan _instance;
        EFModels pte = new EFModels();
   
        public Thongtinbenhnhan()
        {
            InitializeComponent();
        }
       
        public void Bindinggrid(List<ThongTinBenhNhan> listpatient)
        {
            listpatient.Reverse();
            dtgv_patient.Rows.Clear();
            foreach (var item in listpatient)
            {
                int index = dtgv_patient.Rows.Add();
                dtgv_patient.Rows[index].Cells[0].Value = item.soDienThoai;
                dtgv_patient.Rows[index].Cells[1].Value = item.tenBenhNhan;
                if (item.gioiTinh == true)
                {
                    dtgv_patient.Rows[index].Cells[2].Value = "Nam";
                }
                else
                {
                    dtgv_patient.Rows[index].Cells[2].Value = "Nữ";
                }

                dtgv_patient.Rows[index].Cells[3].Value = item.namSinh;
                dtgv_patient.Rows[index].Cells[4].Value = item.diaChi;
                dtgv_patient.Rows[index].Cells[5].Value = item.ngayKhamDauTien;
                dtgv_patient.Rows[index].Cells[6].Value = item.lyDoDenKham;
              
            }

        }
        private void ThongTinBenhNhan_Load(object sender, EventArgs e)
        {
            List<ThongTinBenhNhan> listpatient = pte.ThongTinBenhNhans.ToList();
            Bindinggrid(listpatient);
        }
        public void load()
        {
            List<ThongTinBenhNhan> listpatient = pte.ThongTinBenhNhans.ToList();
            Bindinggrid(listpatient);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tslblhienthi.Text=string.Format("Hôm nay là  ngày {0} - Bây giờ là {1}", DateTime.Now.ToString("dd/MM/yyyy"),DateTime.Now.ToString("hh:mm:ss tt"));
        }
        private void tsbtn_exel_Click(object sender, EventArgs e)
        {
            if (dtgv_patient.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dtgv_patient.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dtgv_patient.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dtgv_patient.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_patient.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dtgv_patient.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            List<ThongTinBenhNhan> listpatient = new List<ThongTinBenhNhan>();
            string keyword = txt_timkiem.Text.ToLower();
            foreach (var thongtinbenhnhan in pte.ThongTinBenhNhans)
            {

                if (thongtinbenhnhan.soDienThoai.Contains(keyword) || thongtinbenhnhan.tenBenhNhan.ToLower().Contains(keyword))
                {
                    // Thêm khoa vào danh sách kết quả
                    listpatient.Add(thongtinbenhnhan);
                }
            }
            // Hiển thị kết quả tìm kiếm lên giao diện
            Bindinggrid(listpatient);
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthembenhnhan addpatient = new frmthembenhnhan();
            addpatient.ShowDialog();
            ThongTinBenhNhan_Load(sender, e);
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbtn_exel_Click(sender, e);
        }

        public void UpdatePatientDataGrid()
        {
            dtgv_patient.Rows.Clear();
            List<ThongTinBenhNhan> listpatient = pte.ThongTinBenhNhans.ToList();
            Bindinggrid(listpatient);
        }

        private void tsbtn_Sua_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            string patientId = dtgv_patient.SelectedRows[0].Cells[0].Value.ToString();
            frmthembenhnhan updatepatient = new frmthembenhnhan(patientId);
            updatepatient.ShowDialog();

            if (updatepatient.IsDataSaved)
            {
                ThongTinBenhNhan updatedPatient = updatepatient.UpdatedPatient;
                if (updatedPatient != null)
                {
                    foreach (DataGridViewRow row in dtgv_patient.Rows)
                    {
                        string selectedPatientId = row.Cells[0].Value.ToString();
                        if (selectedPatientId == updatedPatient.soDienThoai)
                        {
                            row.Cells[1].Value = updatedPatient.tenBenhNhan;
                            row.Cells[3].Value = updatedPatient.namSinh.ToString("dd/MM/yyyy");
                            row.Cells[2].Value = updatedPatient.gioiTinh ? "Nam" : "Nữ";
                            row.Cells[4].Value = updatedPatient.diaChi;
                            row.Cells[5].Value = updatedPatient.ngayKhamDauTien.ToString("dd/MM/yyyy");
                            row.Cells[6].Value = updatedPatient.lyDoDenKham;
                            break;
                        }
                    }
                }
            }
        }

        private void tsbtn_them_Click(object sender, EventArgs e)
        {
            frmthembenhnhan addpatient = new frmthembenhnhan();
            addpatient.ShowDialog();
            ThongTinBenhNhan_Load(sender, e);
        }

        private void dtgv_patient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            string patientId = dtgv_patient.SelectedRows[0].Cells[0].Value.ToString();
            frmthembenhnhan updatepatient = new frmthembenhnhan(patientId);
            updatepatient.ShowDialog();

            if (updatepatient.IsDataSaved)
            {
                ThongTinBenhNhan updatedPatient = updatepatient.UpdatedPatient;
                if (updatedPatient != null)
                {
                    foreach (DataGridViewRow row in dtgv_patient.Rows)
                    {
                        string selectedPatientId = row.Cells[0].Value.ToString();
                        if (selectedPatientId == updatedPatient.soDienThoai)
                        {
                            row.Cells[1].Value = updatedPatient.tenBenhNhan;
                            row.Cells[3].Value = updatedPatient.namSinh.ToString("dd/MM/yyyy");
                            row.Cells[2].Value = updatedPatient.gioiTinh ? "Nam" : "Nữ";
                            row.Cells[4].Value = updatedPatient.diaChi;
                            row.Cells[5].Value = updatedPatient.ngayKhamDauTien.ToString("dd/MM/yyyy");
                            row.Cells[6].Value = updatedPatient.lyDoDenKham;
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmthanhtoan frmthanhtoan = new frmthanhtoan();
            frmthanhtoan.ShowDialog();  
        }

        private void dtgv_patient_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex%2== 0) // Chỉ số cột, ví dụ: cột đầu tiên
            {
                // Thiết lập màu nền cho cột
                e.CellStyle.BackColor = Color.SkyBlue;
                e.CellStyle.ForeColor = Color.Black;
            }
            else
            {
                // Thiết lập màu nền cho hàng
                e.CellStyle.BackColor = Color.SkyBlue;
                e.CellStyle.ForeColor = Color.Black;
            }

     
        }

        private void dtgv_patient_DefaultCellStyleChanged(object sender, EventArgs e)
        {
            dtgv_patient.DefaultCellStyle.Font = new Font("Arial", 40, FontStyle.Bold);
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            frmthanhtoan paypatient = new frmthanhtoan(dtgv_patient.SelectedRows[0].Cells[0].Value.ToString());
            paypatient.ShowDialog();
        }
    }
}
