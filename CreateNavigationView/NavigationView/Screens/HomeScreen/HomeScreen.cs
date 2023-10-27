using DAL.DAL.EF;
using BLL.BLL;
using NavigationView.widgets;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NavigationView.Screens.HomeScreen;
/*using static BLL.DAL.EF.EFModels;*/
using BLL.DAL.EF;
using static DAL.DAL.EF.EFModels;

namespace NavigationView.UserControls
{
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            generateDynamicUC();

            FillChart();
            using (var context = new EFModels())
            {
                var data = context.HoaDons
                    .GroupBy(hd => hd.ngayThanhToan)
                    .Select(g => new { Ngay = g.Key, TongSoTien = g.Sum(hd => hd.tongSoTien) })
                    .ToList();

                chart_profit.Series["Profit"].Points.Clear();

                foreach (var item in data)
                {
                    chart_profit.Series["Profit"].Points.AddXY(item.Ngay, item.TongSoTien);
                }

                chart_profit.Series["Profit"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            }

            //cards
            using (EFModels dbContext = new EFModels())
            {
                int CountLSK = dbContext.CountLSK();
                lbl_ap.Text = CountLSK.ToString();
            }

            using (EFModels dbContext = new EFModels())
            {
                int CountPatient = dbContext.CountPatient();
                lbl_patient.Text = CountPatient.ToString();
            }

            using (EFModels dbContext = new EFModels())
            {
                decimal totalProfit = dbContext.GetTotalProfit();
                string formattedProfit = totalProfit.ToString("N3");

                formattedProfit = formattedProfit.Substring(0, formattedProfit.Length - 3);

                lbl_revenue.Text = formattedProfit;
            }
        }

        // APPOINTMENTS
        private void generateDynamicUC()
        {
            FLP_patient.Controls.Clear();

            using (var context = new EFModels())
            {
                var items = context.GetAPItems();

                if (items != null)
                {
                    if (items.Count > 0)
                    {
                        UCCard[] listItems = new UCCard[items.Count];
                        for (int i = 0; i < items.Count; i++)
                        {
                            // check ngayKham: Chi hien ra lich kham benh cho hom nay
                            if (items[i].ngayKham.Date == DateTime.Today)
                            {
                            listItems[i] = new UCCard();

                            listItems[i].FullName = items[i].tenBenhNhan;
                            listItems[i].Reason = items[i].lyDoDenKham;
                            listItems[i].Time = items[i].ngayKham.ToString();

                            FLP_patient.Controls.Add(listItems[i]);
                            }
                        }
                    }
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            generateDynamicUC();
        }

        // CHART PROFIT
        void FillChart()
        {
            var profitService = new ProfitService();
            var profits = profitService.GetProfitsForChart();
            var chartData = new BindingList<ChartData>(profits.Select(p => new ChartData { Ngay = p.Ngay, Profit = p.Profit }).ToList());
            chart_profit.DataSource = chartData;

            chart_profit.Series["Profit"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;

            // Custom palette colors
            var customColors = new[]
            {
        System.Drawing.Color.FromArgb(178, 231, 239),
    };

            chart_profit.Series["Profit"].XValueMember = "Ngay";
            chart_profit.Series["Profit"].YValueMembers = "Profit";

            // Custom colors's event
            chart_profit.Customize += ChartProfit_Customize;
        }

        private void ChartProfit_Customize(object sender, EventArgs e)
        {
            var chart = (System.Windows.Forms.DataVisualization.Charting.Chart)sender;
            var series = chart.Series["Profit"];
            var points = series.Points;

            // Custom palette colors
            var customColors = new[]
            {
                System.Drawing.Color.FromArgb(178, 231, 239),
            };

            series.BackSecondaryColor = System.Drawing.Color.Transparent;

            for (int i = 0; i < points.Count; i++)
            {
                int colorIndex = i % customColors.Length;
                points[i].Color = customColors[colorIndex];
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormNewAP addform = new FormNewAP();
            addform.Show();
        }
    }
}