using BLL.BLL.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationView.bill
{
    public partial class Bill : Form
    {
        private BillService _billService;
        public Bill()
        {
            InitializeComponent();
            _billService = new BillService();
        }

        private void button1_Click(object sender, EventArgs e) // button xuat hoa don
        {
            var maHoaDon = textBox1.Text;
            var bill = _billService.GetBillDetails(maHoaDon);

            if (bill != null)
            {
                MessageBox.Show("Đã xuất hóa đơn thành công. Mã hóa đơn: " + maHoaDon);
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("Không tìm thấy hóa đơn với mã: " + maHoaDon);
            }
        }

        private void button2_Click(object sender, EventArgs e) // button tim kiem
        {
            var maHoaDon = textBox1.Text;
            var bill = _billService.GetBillDetails(maHoaDon);

            if (bill != null)
            {
                label8.Text = bill.MaBenhNhan.ToString();
                label9.Text = bill.TenBenhNhan;
                label13.Text = bill.MaCanLamSan.ToString();
                label10.Text = bill.NoiDungChuanDoan;
                label11.Text = bill.LuaChonDieuTri;
                label12.Text = bill.TongSoTien.ToString();
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("Không tìm thấy hóa đơn với mã: " + maHoaDon);
            }
        }
    }
}
