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
            #region Question5
            
            
            //for (int m = GetInteger("Enter starting number"), n = GetInteger("Enter ending number"); m < n; m++)
            //{
            //    if (m % 2 != 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(m);
            //}
            #endregion
            #region Question6

            //for (int m = GetInteger("Enter starting number"), n = GetInteger("Enter ending number"); m < n; m++)
            //{
            //    if (m % 2== 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(m);
            //}
            #endregion
            #region Question7

            //int i = GetInteger("Enter divisible number");
            //for (int m = 1, n = 100; m <= n; m++)
            //{
                
            //    if (m % i != 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("The numbers that are divisible by " + i + " are : " + m);
            //}
            #endregion
            #region Question8

            //int m = GetInteger("Enter the number");
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(m + "x" + i + "=" + m*i);
            //}
            #endregion
            #region Question9

            //Console.WriteLine("Multiplication table for 1 to 5 upto 20 is : ");
            //for( int m = 1 , n=20 ; m <=n; m++)
            //{
            //    Console.WriteLine(m*1 + "      " + m*2 + "       " + m*3 + "       " + m*4 + "       " + m*5 + "       "  ); ;
            //}
            #endregion
            #region Question10

            //int sum = 0;
            //int n = GetInteger("Enter the number");
            //for (int i = 1; i <= n; i++)
            //{
            //    sum += i;

            //}
            //Console.WriteLine("The sum of all the numbers between 1 to " + n + " = " + sum);
            #endregion
            #region Question11

            //int sum = 0;
            //int a = 0;
            //int n = GetInteger("Enter a number");
            //while (a <= n)
            //{
            //    Console.WriteLine("The sum of all th even numbers from " + a + " to " + n + " = "  + sum);
            //    a = a + 2;
            //    sum += a;
            //}
            #endregion
            #region Question12

            //int sum = 1;
            //int a = 1;
            //int n = GetInteger("Enter a number");
            //while (a <= n)
            //{
            //    Console.WriteLine("The sum of all the odd numbers from " + a + " to " + n + " = " + sum);
            //    a = a + 2;
            //    sum += a;
            //}
            #endregion
            #region Question13

            //int sum = 0;
            //int a = 0;
            //int n = GetInteger("Enter a number");
            //int k = GetInteger("Enter number to be multiples");
            //while (a <= n)
            //{
            //    Console.WriteLine("The sum of all the odd numbers from " + a + " to " + n + " = " + sum);
            //    a = a + k;
            //    sum += a;
            //}
            #endregion
            #region Question14

            //int multiple = 1;
            //int n = GetInteger("Enter the ending number");
            //for (int i = 1 ; i <= n; i++)
            //{
            //    multiple *= i;
            //}
            //Console.WriteLine("Factorial 1 to " + n + " = " + multiple);
            #endregion

            int sem = GetInteger("Enter the number of semesters");
            int sub = GetInteger("Enter the number of subjects");
            int i = 1;
            int m = 1;
            int sum = 0;
            
            while (i < sem)
            {
                Console.WriteLine("Semester = " + i);
                i++;

                while (m <= sub)
                {
                    int submar = GetInteger("Enter the mark of the subject " + m);
                    m++;
                    sum += submar;
                    
                }
                
                Console.WriteLine("Total marks for this semester = " + sum);
                Console.WriteLine("Average mark for this semester = " + sum / sub);

                
               
               
            }
            
           
           
                
            


















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

