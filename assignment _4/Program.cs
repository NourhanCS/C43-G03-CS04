using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace assignment__4
{
    internal class Program
    {
        #region Q9
        //9-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example
        #region passing by value
        //static void swap(int X, int y)
        //{
        //    //int temp = X;
        //X = y;
        //y = temp;
        //Console.WriteLine($"X= {X} , Y={y}");


        //}

        #endregion

        #region passing by reference
        //static void Swap(ref int X, ref int y)
        //{
        //    int temp = X;
        //    X = y;
        //    y = temp;
        //    Console.WriteLine($"X= {X} , Y={y}");


        //}
        #endregion
        #endregion

        #region Q10
        //10-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

        #region 1-bassing by value  
        //static void fun1(int[] arr)
        //{
        //    if (arr == null)
        //        return;
        //    //arr[0] = 100;
        //    arr = new int[] { 100, 200, 300 };

        //}
        #endregion

        #region 2-passing by reference
        //static void fun2( ref int[] arr)
        //{
        //    if (arr == null)
        //        return;
        //   // arr[0] = 100;
        //    arr = new int[] { 100, 200, 300 };

        //}
        #endregion
        #endregion

        #region Q11
        //11-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        //static void sumsub(int x,int y ,out int sum ,out int sub)
        //{
        //    sum = x+y;
        //    sub = y-x;
        //}

        #endregion

        #region Q12
        //12-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
        //Output should be like
        //Enter a number: 25
        //The sum of the digits of the number 25 is: 7
        //static int Sumdigits (int num)
        //{
        //    int sum = 0;
        //    while (num!=0)
        //    {
        //        int digit = num % 10;
        //        sum += digit;
        //        num /= 10;

        //    }

        //    return sum;

        //}
        #endregion

        #region Q13
        //13-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
        //static bool IsPrime(int num)
        //{
        //    if (num == 1)
        //        return false;
        //    for (int i = 2; i < num; i++)
        //    {
        //        if (num % i == 0)
        //            return false;

        //    }
        //    return true;

        //}
        #endregion

        #region Q14
        //14-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        //static void MinMaxArray(ref int[]arr,out int max,out int min)
        //{
        //     max = arr[0];  min = arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (max < arr[i])
        //            max = arr[i];

        //        if (min > arr[i])
        //            min = arr[i];
        //    }


        //}

        #endregion

        #region Q15
        //15-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        //     static long Fact(int num)
        //     {
        //     int fact = 1;

        //     for (int i = 1; i<=num; i++)
        //{
        //         fact*=i;
        //}


        //     return fact;
        //     }

        #endregion

        #region Q16
        //16-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

        static string ChangeChar(string text,int position,char c)
        {
            text = text.Remove(position,1);
            text = text.Insert(position, c.ToString());

            return text;
        }


        #endregion
            
        static void Main(string[] args)
        {
            #region Q1
            //1- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order
            //int Size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter number of Size");
            //    flage = int.TryParse(Console.ReadLine(), out Size);
            //} while (!flage);

            //int[] arr01 = new int[Size];
            //int[] arr02 = new int[Size];
            //int[] arr03 = new int[Size * 2];

            //for (int i = 0; i < Size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i + 1}");
            //        flage02 = int.TryParse(Console.ReadLine(), out arr01[i]);
            //    } while (!flage02);

            //}
            //for (int i = 0; i < Size; i++)
            //{
            //    bool flage03;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i + 1}");
            //        flage03 = int.TryParse(Console.ReadLine(), out arr02[i]);
            //    } while (!flage03);

            //}

            //int x;
            //for (x = 0; x < Size; x++)
            //{
            //    arr03[x] = arr01[x];
            //}

            //for (int i = 0; i < Size; i++)
            //{

            //    arr03[x] = arr02[i];
            //    x++;
            //}
            //int temp;
            //for (int i = 0; i < Size * 2; i++)
            //{
            //    for (int j = i + 1; j < Size * 2; j++)
            //    {
            //        if (arr03[i] > arr03[j])
            //        {
            //            temp = arr03[i];
            //            arr03[i] = arr03[j];
            //            arr03[j] = temp;

            //        }
            //    }
            //}
            //Console.WriteLine("Sorted array :");
            //for (int i = 0; i < Size * 2; i++)
            //{

            //    Console.WriteLine($" {arr03[i]}");
            //}

            #endregion

            #region Q2
            //int Size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter number of Size");
            //    flage = int.TryParse(Console.ReadLine(), out Size);
            //} while (!flage);

            //int[] arr = new int[Size];
            //int[] freq = new int[Size];

            //for (int i = 0; i < Size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i + 1}");
            //        flage02 = int.TryParse(Console.ReadLine(), out arr[i]);
            //        freq[i] = -1;
            //    } while (!flage02);

            //}

            //int X, j, counter = 0;  

            //for (int i = 0; i < Size; i++) 
            //{
            //    counter = 1;

            //    for (j = i + 1; j < Size; j++)
            //    {

            //        if (arr[i] == arr[j])
            //        {
            //            counter++;
            //            freq[j] = 0;
            //        }

            //    }
            //    if (freq[i] != 0)
            //    {
            //        freq[i] = counter;

            //    }

            //}
            //Console.WriteLine("Frequesncy Equal = ");
            //for (int i = 0; i < Size; i++)
            //{
            //    if (freq[i] > 0)
            //        Console.WriteLine($"{arr[i]} Repeated {freq[i]}");
            //}

            #endregion

            #region Q3
            //3- Write a program in C# Sharp to find maximum and minimum element in an array
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter size of array");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);

            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    bool flag02;
            //    do
            //    {
            //        Console.WriteLine($"Enter number{i + 1}");
            //        flag02 = int.TryParse(Console.ReadLine(), out arr[i]);

            //    } while (!flag02);
            //}
            //int max =arr[0];
            //int min =arr[0];
            //for(int i=0;i<size;++i)
            //{
            //    if (max < arr[i])
            //        max = arr[i];
            //    if (min > arr[i])
            //        min =arr[i];
            //}
            //Console.WriteLine($"Max={max}");
            //Console.WriteLine($"Min={min}");


            #endregion

            #region Q4
            //4- Write a program in C# Sharp to find the second largest element in an array
            //int size;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Enter size number");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);
            //int[] arr = new int[size];

            //for(int i=0;i<size;i++)
            //{
            //    bool flag02;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i + 1}");
            //        flag02 = int.TryParse(Console.ReadLine(), out arr[i]);

            //    } while (!flag02);
            //}
            //int temp;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i+1; j < size; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }

            //}
            //int secmax = arr[size - 2];
            //Console.WriteLine($" second largeest element:{secmax}");
            #endregion

            #region Q5
            //5-. Consider an Array of Integer values with size N, having values as    
            //in this Example

            // 7      0    0   0   0   5   6   7   5   0   7   5   3

            //write a program find the longest distance between Two equal cells.In this example.The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2(cell 2 and cell 3).
            //In the example above, the longest distance is between the first 7 and the
            //10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //And the 10th 7s.

            //Note:
            //-Array values will be taken from the user
            //-If you have input like 1111111 then the distance is the number of
            //Cells between the first and the last cell

            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter size number");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    bool flag02;
            //    do
            //    {
            //        Console.WriteLine($"Enter number {i+1}");
            //        flag02 = int.TryParse(Console.ReadLine(), out arr[i]);

            //    } while (!flag02);
            //}

            //int distance = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i+1; j < size; j++)
            //    {
            //        if (arr[i] == arr[j])
            //            if (distance < j - i - 1)
            //                distance = j - i - 1;
            //    }
            //}
            //Console.WriteLine($"distance ={distance}");


            #endregion

            #region Q6
            //6- Given a list of space separated words, reverse the order of the words.
            //Input: this is a test       Output: test a is this
            //Input: all your base        Output: base your all
            //Input: Word Output: Word
            // Note : 
            // Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine Statement

            //   Console.WriteLine("Enter statement");
            //string statement=Console.ReadLine();
            //   string result = "";
            //   string[] str = statement.Split(" ");

            //   for (int i=str.Length-1;i>=0; i--)
            //   {
            //       result += str[i]+" ";
            //   }
            //   Console.WriteLine(result);
            #endregion

            #region Q7
            //int[,] arr01 = new int[3, 3];
            //int[,] arr02 = new int[3, 3];

            //Console.WriteLine($" Enter Numbers");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arr01[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arr02[i, j] = arr01[i, j];
            //    }
            //}

            //Console.WriteLine("Second Array");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(arr02[i, j]);
            //    }
            //}
            #endregion

            #region Q8
            //8- Write a Program to Print One Dimensional Array in Reverse Order

            //int[] arr = { 1, 2, 3, 4, 5 };
            //for (int i = arr.Length-1;i>=0 ; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

            #region Q9 value type parameters
            #region 1- passing by value

            //int x = 3, y = 5;

            //swap(x, y);

            //Console.WriteLine($"X= {x} , Y={y}");
            #endregion
            #region 2-passing by reference
            //int x = 3, y = 5;

            //Swap(ref x, ref y);

            //Console.WriteLine($"X= {x} , Y={y}");
            #endregion
            #endregion

            #region Q10 reference type parameters
            #region 1- passing by value
            //Console.WriteLine("passing by value");
            //int[] arr = { 1, 2, 3 };
            //fun1(arr);
            //for (int i = 0; i <arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion
            #region 2-passing by reference
            //Console.WriteLine("passing by reference");
            //int[] arr02 = { 1, 2, 3 };
            //fun2(ref arr02);
            //for (int i = 0; i < arr02.Length; i++)
            //{
            //    Console.WriteLine(arr02[i]);
            //}

            #endregion

            #endregion

            #region Q11
            //int x = 10;
            //int y= 20;
            //int sum, sub;
            //sumsub(x, y, out sum, out sub);
            //Console.WriteLine($"sum = {sum}");
            //Console.WriteLine($"sub = {sub}");


            #endregion

            #region Q12
            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine($"Enter number:");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag);

            //int result = Sumdigits(num);

            //Console.WriteLine($"The sum of the digits of the number is: {result}");

            #endregion

            #region Q13
            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine($"Enter Number:");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag);

            //Console.WriteLine(IsPrime(num));

            #endregion

            #region Q14
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine($"Enter number of size");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);

            //bool flag02;
            //int[] numbers = new int[size];
            //for (int i = 0; i<size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter Number :");

            //            flag02 = int.TryParse(Console.ReadLine(), out numbers[i]);

            //    } while (!flag02);
            //}
            //int max, min;
            //MinMaxArray(ref numbers, out max, out min);
            //Console.WriteLine($"max = {max}");
            //Console.WriteLine($"min = {min}");



            #endregion

            #region Q15
            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter number");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag);

            //long result;
            //result = Fact(num);

            //Console.WriteLine($"factorial of the number {num} = {result}");
            #endregion

            #region Q16
            //string str = "Hello";
            //string result = ChangeChar(str, 4, 'l');
            //Console.WriteLine(result);
            #endregion

        }
    }
    }
    
