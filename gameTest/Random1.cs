using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gameTest
{
    internal class Random1
    {
        public  bool RandNum1(int num)
        {
            int tmp = 0;

            Random rnd = new Random();

            if (num == 90)
            {
                tmp = rnd.Next(1, 101);

                if (tmp >= 1 && tmp <= 90)
                    return true;
                else return false;
            }
            else if (num == 80)
            {
                tmp = rnd.Next(1, 101);

                if (tmp >= 1 && tmp <= 80)
                    return true;
                else return false;
            }
            else if (num == 70)
            {
                tmp = rnd.Next(1, 101);

                if (tmp >= 1 && tmp <= 70)
                    return true;
                else return false;
            }
            else
            return false;
        }        
    }
}
