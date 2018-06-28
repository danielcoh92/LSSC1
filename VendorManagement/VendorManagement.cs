using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSSC.VendorManagement
{
    public partial class VendorManagement : ManagementGUI
    {
        List<Vendor> vendors = new List<Vendor>();
        public VendorManagement()
        {
            InitializeComponent();
        }
        public Vendor add_new_vendor(String id, String email, String name, String location, String phoneNumber, int rating)
        {
            Vendor vendor = new Vendor( id,  email,  name,  location,  phoneNumber,  rating);
            return vendor;
        }
        public Vendor modify_vendor(Vendor vendor,String id, String email, String name, String location, String phoneNumber, int rating)
        {
            return vendor;
        }
        public void remove_vendor(Vendor vendor, List<Vendor> vendors)
        {

        }
        public void order_items_from_vendor()
        {

        }
        public void return_items_to_vendor()
        {

        }




            }
}
