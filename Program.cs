using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetsForMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int[] grades = { 70, 65, 100, 90, 30, 95, 40 };


            //int result = subs(grades);



            //Console.WriteLine(result);

            int grades = 490;
           
            
            int bal = average(grades);

            Console.WriteLine(bal);






        }
        //public static int subs(int[] grades)
        //{
        //    int result = 0;
        //    int studs = 0;

        //    foreach (int grade in grades)
        //    {
        //        result += grade;
        //        studs++;
        //    }
        //    return result;
        //}
        public static int average( int grades)
        {
            int studs = 7;
            int orta =grades/studs;
             return orta;
            
            
        }

    }
}
