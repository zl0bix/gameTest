using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameTest
{
    internal class MenuGame
    {
        public static string[] texts = new string[] { "Сделай выбор оперции, выбирай стрелками вниз-вверх, что бы поддтвердить нажми - Ентер\n",
                "1 : Удар рукой (80% вероятность успеха) 70  урона", "2 : Удар ногой (90% вероятность успеха) 170 урона, затраты маны - 1", "3 : Выпить хилку, 16-50 затраты маны - 1","4 : Выход" };
       // static void Main(string[] args)
        
            
        
        public static void Text(int i)//Замена цвета менющки
        {
            

            if (i == 1)
            {
                Console.Clear();
                
                Console.WriteLine(MenuGame.texts[0]);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(MenuGame.texts[1]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(MenuGame.texts[2]);
                Console.WriteLine(MenuGame.texts[3]);
                Console.WriteLine(MenuGame.texts[4]);
                Console.WriteLine("\n\n");
                Console.WriteLine("Твоё ХП и мана\t\t\t ХП врага\n");
                Draw.DrowHpPlaer();
                Console.Write("\t\t\t");
                Draw.DrowHpEnemy();
                Console.WriteLine();
                Draw.DrowMana();
            }
            if (i == 2)
            {
                Console.Clear();

                Console.WriteLine(MenuGame.texts[0]);
                Console.WriteLine(MenuGame.texts[1]);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(MenuGame.texts[2]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(MenuGame.texts[3]);
                Console.WriteLine(MenuGame.texts[4]);
                Console.WriteLine("\n\n");
                Console.WriteLine("Твоё ХП и мана\t\t\t ХП врага\n");
                Draw.DrowHpPlaer();
                Console.Write("\t\t\t");
                Draw.DrowHpEnemy();
                Console.WriteLine();
                Draw.DrowMana();
            }
            if (i == 3)
            {
                Console.Clear();

                Console.WriteLine(MenuGame.texts[0]);
                Console.WriteLine(MenuGame.texts[1]);
                Console.WriteLine(MenuGame.texts[2]);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(MenuGame.texts[3]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(MenuGame.texts[4]);
                Console.WriteLine("\n\n");
                Console.WriteLine("Твоё ХП и мана\t\t\t ХП врага\n");
                Draw.DrowHpPlaer();
                Console.Write("\t\t\t");
                Draw.DrowHpEnemy();
                Console.WriteLine();
                Draw.DrowMana();
            }
            if (i == 4)
            {
                Console.Clear();

                Console.WriteLine(MenuGame.texts[0]);
                Console.WriteLine(MenuGame.texts[1]);
                Console.WriteLine(MenuGame.texts[2]);
                Console.WriteLine(MenuGame.texts[3]);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(MenuGame.texts[4]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        public static int Keyss()//работа менюшки
        {
            int num = 0;
            bool flag = false;
            //do
            while (!flag) 
            {
                ConsoleKeyInfo keyPushed = Console.ReadKey();
                if (keyPushed.Key == ConsoleKey.DownArrow)
                {
                    num++;
                    Text(num);
                }
                if (keyPushed.Key == ConsoleKey.UpArrow)
                {
                    num--;
                    Text(num);
                }
                if (keyPushed.Key == ConsoleKey.Enter)
                {
                    flag = true;
                }
                if (num == 0)
                {
                    num = 4;
                    Text(4);
                    Data.gameOverEnemyWin = true;


                }
                if (num == 5)
                {
                    num = 1;
                    Text(1);
                }
            } //while (!flag);
            //Console.Clear();
            return num;

        }
    }
}
