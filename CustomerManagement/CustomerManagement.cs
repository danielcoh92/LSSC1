using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSSC.CustomerManagement
{
    public partial class CustomerManagement : ManagementGUI
    {
        List<Customer> customers;
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {

        }
        public Customer add_new_customer(String id, String email, String fName, String lName, String phoneNumber)
        {
            Customer customer = new Customer(id, email, fName, lName, phoneNumber);

            return customer;
        }
        public List<Customer> modify_customer(List<Customer> customers,String name)
        {
            List<Customer> lst = customers;
            return lst;
        }
        public void delete_customer(List<Customer> customers)
        {

        }
        public Transactions add_new_transaction()
        {
            Transactions sell = new Transactions();
            return sell;
        }
        public void return_item_from_customer(Transactions transaction)
        {

        }
    }
}
