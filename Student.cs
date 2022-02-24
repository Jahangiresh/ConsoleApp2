using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Student
    {
        public string Fullname;
        public int Age;
        public string GroupNo;

        public string fullname 
        {
            get
            {
                return Fullname;
            }
            set
            {
                if (true)
                {

                }
            }
        }

        public string groupno
        {
            get
            {
                return GroupNo;
            }
            set
            {
                

                for (int i = 0; i < value.Length; i++)
                {

                    if (value.Length==4 && char.IsUpper(value[0]) && char.IsDigit(value[++i]))
                    {
                        GroupNo = value;
                    }
                   
                    else
                    {

                        {
                            Console.WriteLine("type again"); break;

                        }
                    }
                }
            }
        }
    }
}
