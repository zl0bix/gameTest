using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameTest
{
    internal class Data
    {
        public static int hpPlaer;
        public static int manaPlaer;
        public static int hpEnemy;//16dmg
        public static bool gameOverPlaerWin;
        public static bool gameOverEnemyWin;
        static Data()
        {
            hpPlaer = 100;
            manaPlaer = 4;
            hpEnemy = 1000;
            gameOverPlaerWin = false;
            gameOverEnemyWin = false;
        }
    }
}
