using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsets
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question1

            //int i = GetInteger("Enter a Number");
            //int a = 1;
            //while (a <= i)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}
            #endregion
            #region Question2
            
            //int m = GetInteger("Enter starting number");
            //int n = GetInteger("Enter ending number");
            //while (m < n) 
            //{
            //    Console.WriteLine(m);
            //    m++;
            //}
            #endregion
            #region Question3

            //int n = GetInteger("Enter a number");
            //int a =2;

            //while (a <= n)
            //{
            //    Console.WriteLine(a);
            //    a=a+2;
            //}
            #endregion
            #region Question4
            
            //int n = GetInteger("Enter a number");
            //int a = 1;

            //while (a <= n)
            //{
            //    Console.WriteLine(a);
            //    a = a + 2;
            //}
            #endregion









        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static int GetInteger(string message)
        {
            PrintMessage(message);
            int a = int.Parse(Console.ReadLine());
            return a;

        }
        
        
    }
    } 

