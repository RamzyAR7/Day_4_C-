using System;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Channels;

namespace Day_4_C_
{
    internal class Program
    {
        enum Day
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }
        static void Main(string[] args)
        {
            #region Problem1
            //int[] arr1 = new int[3];
            //arr1[0] = 1;
            //arr1[1] = 2;
            //arr1[2] = 3;
            //int[] arr2 = new int[] { 1, 2, 3 };
            //int[] arr3 = { 1, 2, 3 };

            //try
            //{
            //    int x = arr1[5]; // Demonstrate IndexOutOfRangeException
            //}
            //catch (IndexOutOfRangeException error)
            //{
            //    Console.WriteLine(error.Message);
            //}

            #endregion

            #region problem2
            //int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] arr2 = new int[5];

            //arr2 = arr1; //Shallow Copy

            //Console.WriteLine("shallow copy ref to same obj");
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());

            ////========================================================

            //arr2 = (int[])arr1.Clone(); //deep copy

            //Console.WriteLine("shallow copy ref to diff objs");
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());

            #endregion

            #region problem3
            //int[,] grades = new int[3,3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter grade for student {i + 1}");
            //    for (int x = 0; x < 3; x++)
            //    {
            //        Console.WriteLine($"subject {x + 1}");
            //        grades[i, x] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"the grade for student {i + 1}");
            //    for (int x = 0; x < 3; x++)
            //    {
            //        Console.Write($"{grades[i, x]}  ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region problem4
            //int[] arr = new int[] { 2, 1, 8, 4, 20 };

            //// BEFORE
            //Console.WriteLine("before");
            //foreach(int A in arr)
            //{
            //    Console.Write($"{A} ");
            //}
            //Console.WriteLine();
            //// ==================================================
            ////sort
            //Array.Sort(arr);

            ////after 
            //Console.WriteLine("sorted");
            //foreach (int A in arr)
            //{
            //    Console.Write($"{A} ");
            //}
            //Console.WriteLine();
            //// ===================================================
            ////reverse
            //Array.Reverse(arr);

            ////after 
            //Console.WriteLine("reversed");
            //foreach (int A in arr)
            //{
            //    Console.Write($"{A} ");
            //}
            //Console.WriteLine();
            ////=================================================
            ////indexOf
            //Console.WriteLine("index of ===> " + Array.IndexOf(arr, 1));
            ////==================================================
            //// coppy
            //int[] arr2 = new int[5];
            //Array.Copy(arr, arr2, 5);

            ////after 
            //Console.WriteLine("copy");
            //foreach (int A in arr2)
            //{
            //    Console.Write($"{A} ");
            //}
            //Console.WriteLine();

            ////===================================================
            ////clear

            //Array.Clear(arr2, 1, 3);

            ////after
            //Console.WriteLine("clear");
            //foreach (int A in arr2)
            //{
            //    Console.Write($"{A} ");
            //}
            //Console.WriteLine();


            #endregion

            #region problem5
            //int[] arr = new int[5] { 1,2,3,5,45};

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine();
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //int x = arr.Length - 1;
            //while (x >= 0)
            //{
            //    Console.WriteLine(arr[x]);
            //    x--;
            //}

            #endregion

            #region problem6
            //int input;
            //do
            //{
            //    Console.WriteLine("enter a positive odd number");
            //    input = int.Parse(Console.ReadLine());
            //} while (input % 2 == 0 || input < 0); // check on the input

            #endregion

            #region problem7
            //int[,] arr_2d = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int x = 0; x < 3; x++)
            //    {
            //        Console.Write($"{arr_2d[i, x]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region problem8
            //Console.WriteLine("Enter the month number");
            //int Num_month = int.Parse(Console.ReadLine());

            //if (Num_month == 1)
            //{
            //    Console.WriteLine("January");
            //}
            //else if (Num_month == 2)
            //{
            //    Console.WriteLine("February");
            //}
            //else if (Num_month == 3)
            //{
            //    Console.WriteLine("March");
            //}
            //else if (Num_month == 4)
            //{
            //    Console.WriteLine("April");
            //}
            //else if (Num_month == 5)
            //{
            //    Console.WriteLine("May");
            //}
            //else if (Num_month == 6)
            //{
            //    Console.WriteLine("June");
            //}
            //else if (Num_month == 7)
            //{
            //    Console.WriteLine("July");
            //}
            //else if (Num_month == 8)
            //{
            //    Console.WriteLine("August");
            //}
            //else if (Num_month == 9)
            //{
            //    Console.WriteLine("September");
            //}
            //else if (Num_month == 10)
            //{
            //    Console.WriteLine("October");
            //}
            //else if (Num_month == 11)
            //{
            //    Console.WriteLine("November");
            //}
            //else if (Num_month == 12)
            //{
            //    Console.WriteLine("December");
            //}
            //else
            //{
            //    Console.WriteLine("invaild input");
            //}

            //string monthNameSwitch = "";
            //switch (Num_month)
            //{
            //    case 1:
            //        monthNameSwitch = "January";
            //        break;
            //    case 2:
            //        monthNameSwitch = "February";
            //        break;
            //    case 3:
            //        monthNameSwitch = "March";
            //        break;
            //    case 4:
            //        monthNameSwitch = "April";
            //        break;
            //    case 5:
            //        monthNameSwitch = "May";
            //        break;
            //    case 6:
            //        monthNameSwitch = "June";
            //        break;
            //    case 7:
            //        monthNameSwitch = "July";
            //        break;
            //    case 8:
            //        monthNameSwitch = "August";
            //        break;
            //    case 9:
            //        monthNameSwitch = "September";
            //        break;
            //    case 10:
            //        monthNameSwitch = "October";
            //        break;
            //    case 11:
            //        monthNameSwitch = "November";
            //        break;
            //    case 12:
            //        monthNameSwitch = "December";
            //        break;
            //    default:
            //        monthNameSwitch = "Invalid month number";
            //        break;
            //}
            //Console.WriteLine($"Month: {monthNameSwitch}");

            #endregion

            #region problem9
            //int[] arr = { 2, 5, 4, 7, 9, 10, 1, 5};

            //Array.Sort(arr);
            //foreach (var i in arr )
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(Array.IndexOf(arr, 5));
            //Console.WriteLine(Array.LastIndexOf(arr, 5));
            #endregion

            #region problem10
            //int[] arr = { 2, 5, 4, 7, 9, 10, 1, 5 };

            //int sum = 0;

            //foreach (var i in arr)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"using foreach ==> {sum}");
            //sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine($"using for ===> {sum}");

            #endregion


            // for part 2
            #region part2
            /*
             * Define an enum called DayOfWeek with values: Monday, Tuesday, Wednesday,
             * Thursday, Friday, Saturday, Sunday.
             * 
             * Write a program that takes an integer input from the user (1-7) and prints the
             * corresponding day using the enum.
             * Use Enum.Parse to convert an integer to an enum value
             */

            int num;
            do
            {
                Console.Write("Enter the Day number (1 - 7) : ");
                num = int.Parse(Console.ReadLine());

            } while (num < 1 || num > 7);

            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), num.ToString());

            Console.WriteLine($"{num} ====> {day}");

            /**
             * 3- What happens if the user enters a value outside the range of 1 to 7?
             * 
             * When the user enters a value outside the range of 1 to 7 
             * (which is invalid for our DayOfWeek enum),
             * the Enum.Parse method will throw an exception. Specifically,
             * it will throw an ArgumentException because it could not find
             * a corresponding value in the enum.
             * 
             * but i handle my code using do..while to not accept any value not between (1 - 7) 
             */
            #endregion
        }
    }
}
