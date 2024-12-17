﻿namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = { 10,20,30};
            //int[] arr2 = { 40,50,60};
            //int[]arr3= new int[arr1.Length +arr2.Length];

            //  Array.Copy(arr1,arr3,3);
            //  Array.ConstrainedCopy(arr2,0,arr3,3,3);

            //  Array.Sort(arr3);

            //  for (int i = 0; i < arr3.Length; i++)
            //  {
            //      Console.WriteLine(arr3[i]);
            //  }
            #endregion

            #region 2- Write a program in C# Sharp to count the frequency of each element of an array.
            //Don't know.
            // int[] arr = { 1, 2, 3, 4, 4, 5, 4, 5, 6, 6 };
            //int freq = 0;
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.Write(arr[i]);  

            //     for (int j = 0;j < arr.Length; j++)
            //     {
            //         if (arr[i] == arr[j])
            //             freq+= arr[i];
            //         Console.Write(freq);

            //     }
            //     Console.WriteLine();

            // }
            //Don't know.

            #endregion

            #region 3- Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] Numbers = new int[5];
            // int max = 0;
            // int min = 0;

            // Console.WriteLine("Enter 5 Numbers to know max and min :");
            // for (int j = 0; j < Numbers.Length; j++)
            // {
            //    Numbers[j]=int.Parse(Console.ReadLine());   

            // }
            // for (int i = 0; i < Numbers.Length; i++)
            // {
            //     if ( Numbers[i]>max)
            //     {
            //         max = Numbers[i];  
            //     }

            //     else if (Numbers[i]<min)
            //     {
            //         min = Numbers[i];  
            //     }
            // }

            // Console.WriteLine($"Maximum element is :  {max}");
            // Console.WriteLine($"Minimum element is :  {min}");

            #endregion

            #region 4- Write a program in C# Sharp to find the second largest element in an array.
            //int[] numbers = { 30, 80, 120,170,400, 200 };


            //int max = 0;
            //int secondmax =0;

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        secondmax = max;
            //        max = numbers[i];
            //    }
            //    else if (numbers[i] > secondmax && numbers[i] != max)
            //    {
            //        secondmax = numbers[i];
            //    }
            //}


            //Console.WriteLine("The second largest element is: " + secondmax);






            #endregion

            #region  5-. Consider an Array of Integer values with size N, having values as in this Example
            //    try
            //    {
            //        Console.Write("Enter the Size of the Array: ");
            //        int size = int.Parse(Console.ReadLine());
            //        int[] arr = new int[size];

            //        Console.WriteLine("Enter the Numbers of the Array:");
            //        for (int i = 0; i < size; i++)
            //        {
            //            arr[i] = int.Parse(Console.ReadLine());
            //        }

            //        int MaxDistance = 0;

            //        for (int i = 0; i < arr.Length; i++)
            //        {
            //            for (int j = i + 1; j < arr.Length; j++)
            //            {
            //                if (arr[i] == arr[j])
            //                {
            //                    int distance = j - i;
            //                    if (distance > MaxDistance)
            //                    {
            //                        MaxDistance = distance;
            //                    }
            //                }
            //            }
            //        }

            //Console.WriteLine("The longest distance between two equal cells is: " + MaxDistance);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Something wrong review code again !");
            //    }





            #endregion

            #region 6- Given a list of space separated words, reverse the order of the words.

            //Console.WriteLine("Enter a space separated words:");
            //string letter = Console.ReadLine();

            //string[] words = letter.Split(" ");

            //string ReversedWord = "";
            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    ReversedWord += words[i];
            //    if (i != 0) 
            //    {
            //        ReversedWord += " ";
            //    }
            //}

            //Console.WriteLine("Reversed Letter: " + ReversedWord);

            #endregion

            #region 7- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //try { 
            //Console.WriteLine("Enter the number of rows:");
            //int rows = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number of columns:");
            //int columns = int.Parse(Console.ReadLine());

            //int[,] Array1 = new int[rows, columns];
            //int[,] Array2 = new int[rows, columns];

            //Console.WriteLine("Enter the elements of the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Element [{i}, {j}]: ");
            //        Array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Array2[i, j] = Array1[i, j];
            //    }
            //}

            //Console.WriteLine("The second array is:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(Array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Something wrong review  again !");
            //}





            #endregion

            #region 8- Write a Program to Print One Dimensional Array in Reverse Order

            //int[] arr = { 1, 2, 3, 4, 5 };
            //Array.Reverse(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}



            #endregion
            //===============================>Function<=====================================================
            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            //When you pass a value type by value, a copy of the variable is passed to the method.
            //changes made to the parameter inside the method do not affect the original variable.
            //int num1 = 4;
            //int num2 = 5;

            //Console.WriteLine(num1); //4
            //Printvaluetype(num1); //7
            //Console.WriteLine(num1); //4 
            ////===============================
            //Console.WriteLine(num2);  //5
            //PrintRefrencetype(ref num2); //9
            //Console.WriteLine(num2);    //9



            #endregion

            #region (Function)2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //int[] numbers = { 1, 2, 3 };
            //int result = sum(numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);

            //int[] numbers = { 1, 2, 3 };
            //int result = sum(ref numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);




            #endregion

            #region 3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int num1, num2,sum, subtract;

            //Console.Write("Enter Number 1: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Number 2: ");
            //num2 = int.Parse(Console.ReadLine());

            //SumAndsubtract(num1,num2,out sum, out subtract);
            //Console.WriteLine($"Sum of {num1} + {num2} = {sum}");
            //Console.WriteLine($"Subtract of {num1} - {num2} = {subtract}");


            #endregion

            #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //  Console.WriteLine("Enter Your Number to calculate the sum of digits: ");
            //  int[]Digits=new int [1];
            //  for (int i = 0; i < Digits.Length; i++)
            //  {
            //      Digits[i] =int.Parse(Console.ReadLine());
            //  }

            //SumDigits(Digits);


            #endregion

            #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //Console.WriteLine("Please, Enter Prime Number: ");
            //int Num = int.Parse(Console.ReadLine());

            //Console.WriteLine(IsPrime(Num));


            #endregion

            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] numbers = { 5, 17, 21, 90, 11, 7 };
            //int max = 0;
            //int min = 0;

            //MinMaxOfArray(numbers, ref min, ref max);
            //Console.WriteLine($"Max of Numbers:  {max}");
            //Console.WriteLine($"Max of Numbers:  {min}");

            #endregion


            #region 7-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.WriteLine("Please, Enter Number  to calculate Factorial: ");
            
            //double Num = double.Parse(Console.ReadLine());
            
            //Console.WriteLine(Factorial(Num));



            #endregion
            #region

            #endregion




        }

        #region Q1)function
        //static void Printvaluetype(int num1)
        //{
        //    num1 = num1 + 3;
        //    Console.WriteLine(num1);
        //}
        //static void PrintRefrencetype(ref int num2)
        //{
        //    num2 = num2 + 4;
        //    Console.WriteLine(num2);
        //}
        #endregion

        #region Q2)
        //static int sum(ref int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr is not null)
        //        {
        //            sum += arr[i];
        //            arr = new int[3] { 100, 200, 300 };
        //            for (int j = 0; j < arr.Length; j++)
        //            {
        //                sum += arr[j];
        //            }
        //        }
        //    }
        //    return sum;
        //}
        #endregion

        #region Q3)
        //static void SumAndsubtract(int Num1, int Num2, out int sum, out int subtraction)
        //{
        //    sum = Num1 + Num2;       //sum
        //    subtraction = Num1 - Num2; //subtract
        //}

        #endregion

        #region Q4)

        //static void SumDigits(int []Number) 
        //{
        //    int sum = 0;
        //    foreach (int number in Number)
        //    {
        //        sum += number;
        //    }
        //    Console.WriteLine(sum);
        //}



        #endregion

        #region Q5) IsPrime
        //static bool IsPrime (int Num)
        //{

        //    if (Num>2 && Num %2 == 0 && Num % Num == 1)
        //        return false;

        //    else return true;

        //}
        #endregion

        #region Q6)

        //static void MinMaxOfArray(int[] array, ref int min, ref int max)
        //{
        //    if (array.Length == 0)
        //    {
        //        Console.WriteLine("The array is empty.");
        //    }
        //    else
        //    {

        //        min = array[0];
        //        max = array[0];

        //        foreach (int number in array)
        //        {
        //            if (number < min)
        //                min = number;

        //            if (number > max)
        //                max = number;
        //        }
        //    }






        //}
        #endregion

        #region Q7)

        //static double Factorial(double num)
        //{
        //    if (num == 0 || num == 1)
        //        return 1;

        //    double result = 1;

         
        //    for (int i = 2; i <= num; i++)
        //    {
        //        result *= i; 
        //    }

        //    return result;
        //}

        #endregion
    }
}
