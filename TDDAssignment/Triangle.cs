using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDAssignment
{
    public class Triangle
    {
        public static double GetHypotenuse(string Length1, string Length2)
        {
            try
            {
                double sideA = Convert.ToDouble(Length1);
                double sideB = Convert.ToDouble(Length2);

                if(sideA <= 0 || sideB <= 0)
                {
                    return -2;
                }

                double hypotenuse = Math.Sqrt((sideA * sideA) + (sideB * sideB));

                return hypotenuse; 
            }

            catch(Exception)
            {
                return -1;
            }
 
        }

        public static double GetArea(string Length1, string Length2)
        {
            try
            {
                double sideA = Convert.ToDouble(Length1);
                double sideB = Convert.ToDouble(Length2);

                double area = sideA * sideB * 0.5;

                return area;
            }
           
            catch(Exception)
            {
                return -1;
            }
        }
    }
}
