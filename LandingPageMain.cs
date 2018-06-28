using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSSC
{
    class LandingPageMain : Form
    {
        private Button vendorMgmtBtn;
        private Button stockMgmtBtn;
        private Button customerMgmtBtn;

        public LandingPageMain(String id)
        {

        }

        private void InitializeComponent()
        {
            this.vendorMgmtBtn = new System.Windows.Forms.Button();
            this.stockMgmtBtn = new System.Windows.Forms.Button();
            this.customerMgmtBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vendorMgmtBtn
            // 
            this.vendorMgmtBtn.Location = new System.Drawing.Point(231, 245);
            this.vendorMgmtBtn.Name = "vendorMgmtBtn";
            this.vendorMgmtBtn.Size = new System.Drawing.Size(147, 23);
            this.vendorMgmtBtn.TabIndex = 0;
            this.vendorMgmtBtn.Text = "Vendor Management";
            this.vendorMgmtBtn.UseVisualStyleBackColor = true;
            this.vendorMgmtBtn.Click += new System.EventHandler(this.vendorMgmtBtn_Click);
            // 
            // stockMgmtBtn
            // 
            this.stockMgmtBtn.Location = new System.Drawing.Point(572, 244);
            this.stockMgmtBtn.Name = "stockMgmtBtn";
            this.stockMgmtBtn.Size = new System.Drawing.Size(75, 23);
            this.stockMgmtBtn.TabIndex = 1;
            this.stockMgmtBtn.Text = "Stock Management";
            this.stockMgmtBtn.UseVisualStyleBackColor = true;
            this.stockMgmtBtn.Click += new System.EventHandler(this.stockMgmtBtn_Click);
            // 
            // customerMgmtBtn
            // 
            this.customerMgmtBtn.Location = new System.Drawing.Point(913, 244);
            this.customerMgmtBtn.Name = "customerMgmtBtn";
            this.customerMgmtBtn.Size = new System.Drawing.Size(175, 23);
            this.customerMgmtBtn.TabIndex = 2;
            this.customerMgmtBtn.Text = "CustomerManagement";
            this.customerMgmtBtn.UseVisualStyleBackColor = true;
            this.customerMgmtBtn.Click += new System.EventHandler(this.customerMgmtBtn_Click);
            // 
            // LandingPageMain
            // 
            this.ClientSize = new System.Drawing.Size(1286, 426);
            this.Controls.Add(this.customerMgmtBtn);
            this.Controls.Add(this.stockMgmtBtn);
            this.Controls.Add(this.vendorMgmtBtn);
            this.Name = "LandingPageMain";
            this.ResumeLayout(false);

        }

        private void vendorMgmtBtn_Click(object sender, EventArgs e)
        {
            new VendorManagement.VendorManagement();
        }

        private void stockMgmtBtn_Click(object sender, EventArgs e)
        {
            new StockManagement.StockManagement();

        }

        private void customerMgmtBtn_Click(object sender, EventArgs e)
        {
            new CustomerManagement.CustomerManagement();
        }
    }
}
