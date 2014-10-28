using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglingDoors_Kata
{
    public class Door
    {
        private int _doorNo;
        public static int CLOSE = 0;
        public static int OPEN = 1;

        public Door(int doorNo)
        {
            // TODO: Complete member initialization
            this._doorNo = doorNo;
        }

        public int[] Pass(int pass)
        {
            int[] result = new int[_doorNo];
            for (int i = 1; i <= pass; i++)
            {
                for (int j = 1; j <= _doorNo; j++)
                {
                    if (j % i == 0)
                        result[j - 1] = 1 - result[j - 1];
                }
            }
            return result;
        }
    }
}
