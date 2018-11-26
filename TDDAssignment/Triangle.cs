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
                double sideLength1 = Convert.ToDouble(Length1);
                double sideLength2 = Convert.ToDouble(Length2);

                double hypotenuse = Math.Sqrt((sideLength1 * sideLength1) + (sideLength2 * sideLength2));

                return hypotenuse; 
            }

            catch(Exception)
            {
                return -1;
            }
 
        }
    }
}
