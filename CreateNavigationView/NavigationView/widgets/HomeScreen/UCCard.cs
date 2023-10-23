using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationView.widgets
{
    public partial class UCCard : UserControl
    {
        public event EventHandler UserControlClicked;
        public UCCard()
        {
            InitializeComponent();

            this.MouseClick += (s, e) =>
            {
                UserControlClicked?.Invoke(this, e);
            };
        }

        //Get & Set
        private string _Time;
        private string _FullName;
        private string _Reason;

        [Category("Custom Props")]
        public string Time
        {
            get { return _Time; }
            set { _Time = value; label_Time.Text = value; }
        }

        [Category("Custom Props")]
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; label_FullName.Text = value; }
        }

        [Category("Custom Props")]
        public string Reason
        {
            get { return _Reason; }
            set { _Reason = value; label_Reason.Text = value; }
        }

        private void label_FullName_Click(object sender, EventArgs e)
        {
            UserControlClicked?.Invoke(this, e);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            UserControlClicked?.Invoke(this, e);
        }
    }
}
