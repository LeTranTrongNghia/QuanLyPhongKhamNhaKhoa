using BLL.BLL.HomeScreen.AP.newAP;
using BLL.DAL.EF;
using DAL.DAL.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationView.Screens.HomeScreen
{
    public partial class FormNewAP : Form
    {
        private newAP newAPInstance;
        public FormNewAP()
        {
            InitializeComponent();
            newAPInstance = new newAP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngayKham = dateTimePicker1.Value;
                int maHoaDon = int.Parse(textBox1.Text);
                int maNhanVien = int.Parse(textBox2.Text);
                int maBenhNhan = int.Parse(textBox3.Text);

                LichSuKham newLichSuKham = newAPInstance.AddLichSuKham(ngayKham, maHoaDon, maNhanVien, maBenhNhan);

                MessageBox.Show("Lịch sử khám đã được thêm thành công.");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
