using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison
{
    public class CalculateLength
    {
        int lengthX, _lengthY, lengthsX, lengthsY;

        public CalculateLength(int lengthX, int lengthY, int lengthsX, int lengthsY)
        {
            this.lengthX = lengthX;
            _lengthY = lengthY;
            this.lengthsX = lengthsX;
            this.lengthsY = lengthsY;
        }
        public double Calculate()
        {
            //lenght = sqrt((X2-x1)^2 + (Y2 - y1)^2);
            double length = Math.Sqrt(Math.Pow((lengthsX - lengthX), 2) + Math.Pow((lengthsY - _lengthY), 2));
            Console.WriteLine(length);
            return length;
        }
    }
}
