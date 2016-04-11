using System;

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
