
using System.Runtime.InteropServices.ComTypes;

namespace Pianino
{
    class Pianino
    { 
        static int[] first_ = new[]
        {
            2093,2217,2349,2489,2637,2794,2960,3136,3322,3520,3729,3951// 12 тактов
        };
        
        static int[] second_ = new[]
        {
             1047,1109,1175,1245,1319,1397,1480,1568,1661,1760,1865,1976,
        };

        static int[] thirt_ = new[]
        {
            261,277,293,311,329,349,370,392,415,440,466,493
        };

      
        static void numerate(int nem_)
        {
            if (nem_ == 1)
            {
                play(first_);
            }
            if (nem_ == 2)
            {
                play(second_);
            }

            if (nem_ == 3)
            {
                play(thirt_);
            }
        }

        static void play(int[] actava)
        {
            
            while (true)
            {
                System.ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F11 || key.Key == ConsoleKey.F5 || key.Key == ConsoleKey.F6)
                {
                    break;
                } 
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(actava[0],200);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(actava[1],200);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(actava[2],200);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(actava[3],200);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(actava[4],200);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(actava[5],200);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(actava[6],200);
                        break;
                    case ConsoleKey.K:
                        Console.Beep(actava[7],200);
                        break;
                    case ConsoleKey.L:
                        Console.Beep(actava[8],200);
                        break;
                }
            }
        }//dfdfdf
        static void Main()
        {
            Console.WriteLine("Для переключения актав дважды нажмите кнопку \n" +
                                           "1-актава f6\n" +
                                           "2-актава f11\n" +
                                           "3-актава f5");
            while (true)
            {
                
                System.ConsoleKeyInfo actava = Console.ReadKey(true);
                switch (actava.Key)
                {
                    case ConsoleKey.F6:
                        Console.WriteLine("f6");
                        numerate(1);
                        continue;
                        break;
                    case ConsoleKey.F11:
                        Console.WriteLine("f11");
                        numerate(2);
                        continue;
                        break;
                    case ConsoleKey.F5:
                        Console.WriteLine("f5");
                        numerate(3);
                        continue;
                        break;
                    default:
                        Console.WriteLine("Выберите актаву");
                        break;
                }
            }
        }

    }
}