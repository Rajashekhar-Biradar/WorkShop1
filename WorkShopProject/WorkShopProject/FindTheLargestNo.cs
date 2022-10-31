using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopProject
{
    public class FindTheLargestNo
    { 
        public static void num<T>(T num1,T num2, T num3) where T : IComparable<T>
    
        {
            if ( num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 )
            {
                Console.WriteLine("{0} greater amomg three",num1);
            }else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                Console.WriteLine("{0} greater amomg three", num2);
            }
            else
             {
                Console.WriteLine("{0} greater amomg three", num3);
            }
        }
    }
}
