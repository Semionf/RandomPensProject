using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PenBooster
    {
        private Pen[] p1 = new Pen[1000];
        public PenBooster(Pen[] penArr)
        {
            this.p1 = penArr;
        }

        public void PrintBlue()
        {
            for (int i = 0; i < p1.Length; i++)
            {
                if (p1[i].color == "Blue")
                {
                    Console.WriteLine(p1[i].color);
                }
            }
        }

        public void PrintBlack()
        {
            for (int i = 0; i < p1.Length; i++)
            {
                if (p1[i].color == "Black")
                {
                    Console.WriteLine(p1[i].color);
                }
            }
        }

        public void PrintRed()
        {
            for (int i = 0; i < p1.Length; i++)
            {
                if (p1[i].color == "Red")
                {
                    Console.WriteLine(p1[i].color);
                }
            }
        }
    }
}
