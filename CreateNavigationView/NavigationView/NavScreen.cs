using NavigationView.Screens.Manage;
using NavigationView.Screens.PatientInformation;
using NavigationView.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationView
{
    public partial class FormTest : Form
    {
        private int quyenTruyCap;

        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        // Change the color of selected's button
        Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedtColor = Color.FromKnownColor(KnownColor.ControlLight);

        public FormTest()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }

        public FormTest(int quyenTruyCap)
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
            this.quyenTruyCap = quyenTruyCap;
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            switch (this.quyenTruyCap)
            {
                case 0:
                    btn_patient.Enabled = true;
                    btn_treatments.Enabled = true;
                    btn_statics.Enabled = true;
                    break;
                case 2:
                case 3:
                case 4:
                    btn_treatments.Enabled=true;
                    break;
                case 5:
                    btn_patient.Enabled=true;
                    break;
                case 1:
                case 6:
                    btn_statics.Enabled=true;
                    break;
            }
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() // Your UserControl list
            { new HomeScreen(), new Thongtinbenhnhan(), new UserControl3(), new frmStatics(),};

            navigationControl = new NavigationControl(userControls, panel2); // create an instance of NavigationControl class
            navigationControl.Display(0); // display UserControl1 as default
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>();

            // create a NavigationButtons instance
            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
            // Make a default selected button
            navigationButtons.Highlight(btn_home);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_home.Height;
            SidePanel.Top = btn_home.Top;
            navigationControl.Display(0);
            navigationButtons.Highlight(btn_home);
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_patient.Height;
            SidePanel.Top = btn_patient.Top;
            navigationControl.Display(1);
            navigationButtons.Highlight(btn_patient);
        }

        private void btn_treatments_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_treatments.Height;
            SidePanel.Top = btn_treatments.Top;
            navigationControl.Display(2);
            navigationButtons.Highlight(btn_treatments);
        }
        private void btn_statics_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_statics.Height;
            SidePanel.Top = btn_statics.Top;
            navigationControl.Display(3);
            navigationButtons.Highlight(btn_statics);
        }

        private void FormTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the program?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Do you really want to exit the program?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
                Close();
            //}
        }
    }
}
