using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string numStr,str,str2,str3 = null;
            Console.WriteLine("Please enter a string:");
            str = Console.ReadLine();
            Console.WriteLine("Please enter a string 2:");
            str2 = Console.ReadLine();
            Console.WriteLine("Please enter a number:");
            numStr = Console.ReadLine();
            int num = int.Parse(numStr);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(str);
            }
            for (int i = 0; i < num; i++)
            {
                str3 += str2;
            }
            Console.WriteLine(str3);
            Console.ReadLine();
            
            Pen p1 = new Pen("Red", 1, (float)0.7);
            Pen p2 = new Pen("Blue", 2, (float)0.5);
            Pen p3 = new Pen("Pink", 3, 1);
            p1.printPen();
            p2.printPen();
            p3.printPen();

            int counterTop = 0, counterButtom = 0;
            Random r  = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 10; i++)
            {
                int num = r.Next(1,100);
                Console.WriteLine(num);
            }
            for (int i = 0; i < 1000; i++)
            {
                int num = r.Next(99,999);
                if (num > 500)
                {
                    counterTop++;
                }
                else if (num < 500)
                {
                    counterButtom++;
                }
            }
            Console.WriteLine("Numbers above 500: " + counterTop + " Numbers below 500: " + counterButtom);
            */
            Pen[] p1 = new Pen[1000];
            string[] color = { "Blue", "Red", "Black" };
            float[] length = { (float)0.5, (float)0.7, 1 };
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 1000; i++)
            {
                int penLength = r.Next(15,25);
                int choice = r.Next(3);
                int choice2 = r.Next(2);
                string randColor = color[choice];
                p1[i] = new Pen(randColor, penLength, length[choice2]);
            }

            PenBooster pb = new PenBooster(p1);
            pb.PrintBlue();
            pb.PrintBlack();
            pb.PrintRed();
            Console.ReadLine();
        }
    }
}
