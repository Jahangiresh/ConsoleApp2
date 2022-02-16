using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Convert.ToString(Console.ReadLine());
            upperlower(a);
            Console.WriteLine(upperlower(a));
        }
        public static string upperlower(string a)
        { 
        
            string bb = "";

            for (int i = 0; i < a.Length; i++)
            {

                if (char.IsUpper(a[i]))
                {
                    bb += char.ToLower(a[i]);
                }
                else
                {
                    bb += char.ToUpper(a[i]);

                }

            }return bb;
           
            
        }
    }
}
