using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSSC
{
   public abstract class ManagementGUI : Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ManagementGUI
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ManagementGUI";
            this.Load += new System.EventHandler(this.ManagementGUI_Load);
            this.ResumeLayout(false);

        }

        private void ManagementGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
