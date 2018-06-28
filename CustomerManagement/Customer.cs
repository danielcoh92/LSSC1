using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSSC.CustomerManagement
{
   public class Customer
    {
        String id;
        String email;
        String fName;
        String lName;
        String phoneNumber;
        List<Transactions> transactions = null;

        public Customer(String id, String email, String fName, String lName, String phoneNumber)
        {

        }
    }
}
