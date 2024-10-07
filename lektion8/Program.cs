using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion8
{

        internal struct matte
    {
        public int tal1;
        public int tal2;    
    }

        
    internal class Program
    {
        static double ConvertMetersToKm(int m)
        {
            
            return m / 1000.0;
        }

        static double ConvertSToH(int t)
        {
            return t / 3600.0;
        }

        static double ConvertKToC(int temp)
        {
            return temp - 273.15;
        }

        static double ConvertCToF(int temp2)
        {
            return temp2 * 9/5 + 32;
        }

        static double ConvertKToF(int temp3)
        {

            return temp3 * 1.8-459.67;
        }

        //7
        static double blabla(int distans, int tid)
        {
            return (double)distans / tid;
        }

        static double calculatesomethingwithxandy(int x, int y)
        {
            return x + y;
        }

        static int calculatevolume(int width, int height, int depth)
        {
            return width * height * depth;
        }

        static int calculatevolume2(FileName myfilename)
        {
            return myfilename.Width * myfilename.Height * myfilename.Depth;
        }

        static matte matte(int tal1, int tal2) {
            int kvot = tal1 / tal2;
            int remainder = tal1 % tal2;
            return new matte() { tal1 = kvot, tal2 = remainder};
        }       
        


        static void Main(string[] args)
        {
            int Width = 43;
            int height = 345;
            int depth = 353;
            
            FileName myfilename = new FileName();
            myfilename.Width = 43;
            myfilename.Height = 345;
            myfilename.Depth = 353;




            Console.WriteLine(ConvertMetersToKm(953) + "Km");
            Console.WriteLine(ConvertSToH(7200) + "hours");
            Console.WriteLine(ConvertKToC(234) + "Celsius");
            Console.WriteLine(ConvertCToF(43) +"Fahrenheit");
            Console.WriteLine(ConvertKToF(234) + "Fahrenheit");
            Console.WriteLine(blabla(5000, 5));
            Console.WriteLine(calculatevolume(Width, height, depth));
            Console.WriteLine(calculatevolume2(myfilename));
            matte skibids = matte(5,2);
            Console.WriteLine(skibids.tal1 + "," + skibids.tal2);
        }
    }
}
