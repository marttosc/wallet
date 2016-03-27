using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class Card
    {
        public Int32 Id { get; set; }
        public User Owner { get; set; }
        public Flag Flag { get; set; }
        public String Number { get; set; }
        public Int32 ExpireMonth { get; set; }
        public Int32 ExpireYear { get; set; }
        public Int32 Cvc { get; set; }
        public Double Limit { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
