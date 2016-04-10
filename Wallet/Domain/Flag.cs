using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Flag
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }

        public override String ToString()
        {
            return Name;
        }
    }
}
