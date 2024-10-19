using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameTest
{
    internal class Work
    {
        public int dmgPanch = 70;
        public int dmgKick = 170;
        public int dmgBoss = 16;
        public int hpHilka = 50;

        public void WorkPlaer(int num) 
        {
            Random1 rrr = new Random1();
            
            if(num == dmgPanch)
            {
                if (rrr.RandNum1(80))
                {
                    Data.hpEnemy -= num;

                    if (Data.hpEnemy <= 0)
                        Data.gameOverPlaerWin = true;

                    if (Data.hpEnemy < 0)
                        Data.hpEnemy = 0;
                }
               

            }
            else if(num == dmgKick && Data.manaPlaer > 0)
            {
                if (rrr.RandNum1(90))
                {
                    Data.hpEnemy -= num;
                    Data.manaPlaer--;

                    if (Data.hpEnemy <= 0)
                        Data.gameOverPlaerWin = true;

                    if (Data.hpEnemy < 0)
                        Data.hpEnemy = 0;

                    if(Data.manaPlaer < 0)
                        Data.manaPlaer = 0;
                }
                
            }

            

        }

        public void WorkEnemy()
        {
            Random1 rrrr = new Random1();
            if (rrrr.RandNum1(70))
            {
                Data.hpPlaer -= dmgBoss;

                if (Data.hpPlaer <= 0)
                {
                    Data.gameOverEnemyWin = true;
                }

                if (Data.hpPlaer < 0)
                    Data.hpPlaer = 0;
            }
            
            
        }

        public void HilPlaer()
        {
            if (Data.manaPlaer > 0)
            {
                Random rnd = new Random();
                Data.hpPlaer += rnd.Next(16, 51);
                Data.manaPlaer--;
            }
            if(Data.manaPlaer < 0)
            {
                Data.manaPlaer = 0;
            }
            if (Data.hpPlaer > 100)
                Data.hpPlaer = 100;
        }



    }
}
