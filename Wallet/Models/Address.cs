using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class Address
    {
        public Int32 Id { get; set; }
        public String Zip { get; set; }
        public String Place { get; set; }
        public String District { get; set; }
        public String State { get; set; }
        public String Uf { get; set; }
    }
}
