using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    public class Program
    {
        static void Main(string[] args)
        {
        }


        public int[] GetPrimeFactor(int composite)
        {
            IList<int> factors = new List<int>();

            if (composite % 2 == 0)
            {
                factors.Add(2);
            }
            else if (composite % 3 == 0)
            {
                factors.Add(3);
            }
            else if (composite % 5 == 0)
            {
                factors.Add(5);
            }
            else
                factors = new int[] { composite };

            return factors.ToArray();
        }
    }
}
