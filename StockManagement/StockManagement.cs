using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSSC.StockManagement
{
    public partial class StockManagement : ManagementGUI
    {
        List<Item> items;
        public StockManagement()
        {
            InitializeComponent();
        }

        public Item add_item(String id, String name, int value, int amount)
        {
            Item item = new Item(id, name, value, value, amount);
            return item;
        }
        public Item modify_item(Item item,String id, String name, int value, int amount)
        {

            return item;
        }
        public void remove_item()
        {
            
        }
        public List<String> add_item_family(String name)
        {
            List<String> lst = new List<String>();
            return lst;
        }
        public List<String> modify_item_family(String name, List<String>curr)
        {
            List<String> lst = curr;
            return lst;
        }
        public void remove_item_family(List<String> curr)
        {
            curr=null;
     
        }
        public List<String> add_item_category(String name)
        {
            List<String> lst = new List<String>();
            return lst;
        }
        public List<String> modify_item_category(List<String> curr)
        {
            List<String> lst = curr;
            return lst;
        }
        public void remove_item_category(List<String> curr)
        {
            curr = null;

        }
    }
}
