using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class User
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Cpf { get; set; }
        public DateTime Birthdate { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public Double Income { get; set; }
        public Address Address { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            var user = (User) obj;

            if (Id != user.Id)
            {
                return false;
            }

            if (!Cpf.Equals(user.Cpf))
            {
                return false;
            }

            if (!Name.Equals(user.Name))
            {
                return false;
            }

            if (!Birthdate.Equals(user.Birthdate))
            {
                return false;
            }

            if (!Password.Equals(user.Password))
            {
                return false;
            }

            if (Income != user.Income)
            {
                return false;
            }

            return true;
        }
    }
}
