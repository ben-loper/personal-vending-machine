using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    public abstract class Change
    {

        public static Dictionary<string, int> GetChangeWithNoDollars(decimal amount)
        {
            Dictionary<string, int> change = new Dictionary<string, int>();

            change.Add("Quarter(s)", 0);
            change.Add("Dime(s)", 0);
            change.Add("Nickel(s)", 0);

            const decimal quarter = .25M;
            const decimal dime = .10M;
            const decimal nickel = .05M;

            while (amount != 0)
            {

                if (amount - quarter >= 0)
                {
                    amount -= quarter;
                    change["Quarter(s)"]++;
                }
                else if (amount - dime >= 0)
                {
                    amount -= dime;
                    change["Dime(s)"]++;
                }
                else if (amount - nickel >= 0)
                {
                    amount -= nickel;
                    change["Nickel(s)"]++;
                }
            }
            return change;
        }
    }
}
