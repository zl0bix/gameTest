using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameTest
{
    internal class Program
    {

       


        static void Main(string[] args)
        {

          bool exitProgram = false;
            Work work = new Work();
            //Console.SetWindowSize(110, 50);

            while (!exitProgram)
            {
                if (Data.hpPlaer <= 0 || Data.hpEnemy <= 0)
                {
                    exitProgram = true;

                }
                
                foreach (string txt in MenuGame.texts)
                    Console.WriteLine(txt);
                

                Console.WriteLine();
                int num = MenuGame.Keyss();//вызов менюшки 


                switch (num)
                {
                    case 1:
                        work.WorkPlaer(work.dmgPanch);
                        System.Threading.Thread.Sleep(150);
                        work.WorkEnemy();
                        System.Threading.Thread.Sleep(150);
                        Console.Clear();

                        break;
                    
                    case 2: 
                        work.WorkPlaer(work.dmgKick);
                        System.Threading.Thread.Sleep(150);
                        work.WorkEnemy();
                        System.Threading.Thread.Sleep(150);
                        Console.Clear();
                        break;
                    case 3:
                        work.HilPlaer();
                        System.Threading.Thread.Sleep(150);
                        work.WorkEnemy();
                        System.Threading.Thread.Sleep(150);
                        Console.Clear();
                        break;
                    
                    case 4:
                        exitProgram = true; 
                         break;
                    
                }                
            }

            if (Data.hpEnemy <= 0)
            {
                Console.Clear();  
                Console.WriteLine("\n\n\n\n\n\t\t\tYou Win!\n\n\n\n\n");
                Console.ReadKey();
            }
            else if (Data.hpPlaer <= 0) 
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\t\t\tYou Loss!\n\n\n\n\n");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\t\t\tGood luck! See you soon\n\n\n\n\n");
                Console.ReadKey();
            }
            /*
              
            Data.hpPlaer = 100;                
            Draw.DrowHpPlaer();

            Console.WriteLine();

            Data.hpPlaer = 90;
            Draw.DrowHpPlaer();

            Console.WriteLine();

            Data.hpPlaer = 70;
            Draw.DrowHpPlaer();

            Console.WriteLine();

            Data.hpPlaer = 41;
            Draw.DrowHpPlaer();


            Console.WriteLine();

            Data.hpPlaer = 39;
            Draw.DrowHpPlaer();
            
            Console.WriteLine();*/
            /*
           while (true)
           {

               if (rnnn.RandNum(70))
               {
                   System.Threading.Thread.Sleep(150);
                   Console.WriteLine("+");
               }
               else
               {
                   System.Threading.Thread.Sleep(150);
                   Console.WriteLine("-");
               }
           }                     */
        }
    }
}
