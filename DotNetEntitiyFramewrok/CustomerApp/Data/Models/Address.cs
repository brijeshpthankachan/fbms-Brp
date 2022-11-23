using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Data.Models
{


    enum AddressType{
        
        Home,
        Office,
        Other

        }

    [Index(nameof(CustomerID),nameof(AddressType),IsUnique =true)]
    internal class Address
    {
        public int Id { get; set; }
        public AddressType AddressType { get; set; }
        public string Ad { get; set; }

        public Customers Customer { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerID { get; set; }
    }
}


