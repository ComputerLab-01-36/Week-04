using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please Lastname :");
                string Lastname = Convert.ToString(value: Console.ReadLine());
                Console.Write("Please ID :");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please GPA :");
                float GPA = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine(value: "Answer = " + (Lastname + ID + GPA));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
        }
    }
}
