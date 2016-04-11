using System;

namespace Domain.Models
{
    public class Card
    {
        public Int32 Id { get; set; }
        public User Owner { get; set; }
        public Flag Flag { get; set; }
        public String Number { get; set; }
        public Int32 ExpireMonth { get; set; }
        public Int32 ExpireYear { get; set; }
        public String Cvc { get; set; }
        public Double Limit { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
