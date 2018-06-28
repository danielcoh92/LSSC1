using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSSC
{
    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        internal LandingPageMain _
        {
            get => default(LandingPageMain);
            set
            {
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            loginBox.Location = new Point(Size.Width/3, Size.Height/4);
            lbl_info_text.Text += "Placeholder placeholder placeholder placeholder placeholder placeholder placeholder placeholder placeholder placeholder placeholder placeholder" +
                " placeholder placeholder placeholder";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
