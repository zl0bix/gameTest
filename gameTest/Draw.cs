using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameTest
{
    internal class Draw
    {
        public static void DrowHpPlaer()
        {
            if (Data.hpPlaer >= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Data.hpPlaer + " ##########");
                Console.ResetColor();
            }
            else if (Data.hpPlaer >= 80 && Data.hpPlaer < 100)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(Data.hpPlaer + " ########"); Console.ResetColor(); Console.Write("__");
                Console.ResetColor();
            }
            else if (Data.hpPlaer >= 60 && Data.hpPlaer < 80)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(Data.hpPlaer + " ######"); Console.ResetColor(); Console.Write("____");
                Console.ResetColor();
            }
            else if (Data.hpPlaer >= 40 && Data.hpPlaer < 60)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(Data.hpPlaer + " ####"); Console.ResetColor(); Console.Write("______");
                Console.ResetColor();
            }
            else if (Data.hpPlaer >= 20 && Data.hpPlaer < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Data.hpPlaer + " ##"); Console.ResetColor(); Console.Write("________");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Data.hpPlaer + " __________");
                Console.ResetColor();
            }
        }


            public static void DrowHpEnemy()
            {
                if (Data.hpEnemy >= 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Data.hpEnemy + " ##########");
                    Console.ResetColor();
                }
                else if (Data.hpEnemy >= 800 && Data.hpEnemy < 1000)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(Data.hpEnemy + " ########"); Console.ResetColor(); Console.Write("__");
                    Console.ResetColor();
                }
                else if (Data.hpEnemy >= 600 && Data.hpEnemy < 800)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Data.hpEnemy + " ######"); Console.ResetColor(); Console.Write("____");
                    Console.ResetColor();
                }
                else if (Data.hpEnemy >= 400 && Data.hpEnemy < 600)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(Data.hpEnemy + " ####"); Console.ResetColor(); Console.Write("______");
                    Console.ResetColor();
                }
                else if (Data.hpEnemy >= 200 && Data.hpEnemy < 400)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(Data.hpEnemy + " ##"); Console.ResetColor(); Console.Write("________");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(Data.hpEnemy + " __________");
                    Console.ResetColor();
                }

            }

        public static void DrowMana()
        {
            if(Data.manaPlaer == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Data.manaPlaer + " ########");
                Console.ResetColor();
            }
            else if(Data.manaPlaer == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Data.manaPlaer + " ######");
                Console.ResetColor();
            }
            else if( Data.manaPlaer == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Data.manaPlaer + " ####");
                Console.ResetColor();
            }
            else if(Data.manaPlaer == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Data.manaPlaer + " ##");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Data.manaPlaer);
                Console.ResetColor();
            }
        }

    }
}
