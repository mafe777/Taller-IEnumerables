using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables.Logic
{
    public class DescompotitionIntoFactors
    {
        public static List<int> GetPrimeFactors(int number)
        {
            List<int> factors = new List<int>();
            int divisor = 2;

            while (number > 1)
            {
                if (number % divisor == 0)
                {
                    factors.Add(divisor);
                    number /= divisor;

                }
                else
                {
                    divisor++;

                }

            }
            return factors;
        }
    }
}
