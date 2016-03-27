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

        public static bool ValidateCpf(String cpf)
        {
            if (cpf.Equals("00000000000") || cpf.Equals("11111111111") ||
                cpf.Equals("22222222222") || cpf.Equals("33333333333") ||
                cpf.Equals("44444444444") || cpf.Equals("55555555555") ||
                cpf.Equals("66666666666") || cpf.Equals("77777777777") ||
                cpf.Equals("88888888888") || cpf.Equals("99999999999") ||
               (cpf.Length != 11))
            {
                return false;
            }

            char dig10, dig11;
            int sm, i, r, num, peso;

            sm = 0;
            peso = 10;

            for (i = 0; i < 9; i++)
            {
                num = (int) (cpf[i] - 48);

                sm += num * peso;

                peso--;
            }

            r = 11 - (sm % 11);

            if ((r == 10) || (r == 11))
            {
                dig10 = '0';
            }
            else
            {
                dig10 = (char) (r + 48);
            }

            sm = 0;
            peso = 11;

            for (i = 0; i < 10; i++)
            {
                num = (int) (cpf[i] - 48);

                sm += num * peso;

                peso--;
            }

            r = 11 - (sm % 11);

            if ((r == 10) || (r == 11))
            {
                dig11 = '0';
            }
            else
            {
                dig11 = (char) (r + 48);
            }

            return ((dig10 == cpf[9]) && (dig11 == cpf[10]));
        }
    }
}
