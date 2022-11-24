using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pen
    {
        public string color;
        public int lenght;
        public float hodLength;

        public Pen(string color, int length, float hodLength)
        {
            this.color = color;
            this.lenght = length;
            this.hodLength = hodLength;
        }
        public void printPen()
        {
            string details = "The color is: " + this.color + ", Pen length is: " + this.lenght.ToString() + ", Hod length is: " + this.hodLength.ToString();
            Console.WriteLine(details);
        }
        public void setRandomSize()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            this.lenght = r.Next(5,10);        }
    }
}
