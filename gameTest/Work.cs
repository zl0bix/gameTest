using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameTest
{
    internal class Work
    {
        public int dmgPanch = 50;
        public int dmgKick = 150;
        public int dmgBoss = 16;

        public void WorkPlaer(int num) 
        {
            Random1 rrr = new Random1();
            
            if(num == dmgPanch)
            {
                if (rrr.RandNum1(80))
                {
                    Data.hpEnemy -= num;
                }
                else
                {
                    Console.WriteLine("Miss");
                }

            }
        else if(num == dmgKick && Data.manaPlaer > 0)
            {
                if (rrr.RandNum1(90))
                {
                    Data.hpEnemy -= num;
                    Data.manaPlaer--;
                }
                else 
                {
                    Console.WriteLine("Miss");
                }
            }

            if(Data.hpEnemy <= 0 )
                Data.gameOverPlaerWin = true;

        }

        public void WorkEnemy()
        {
            Random1 rrrr = new Random1();
            if (rrrr.RandNum1(70))
            {
                Data.hpPlaer -= dmgBoss;
            }
            else
            {
                Console.WriteLine("Miss");
            }
            if(Data.hpPlaer <= 0)
            {
                Data.gameOverEnemyWin = true;   
            }
        }



    }
}
