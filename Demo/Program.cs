namespace Demo
{
    internal class Program
    {
        //function
        static void printShape(int count, string pattern = "**&**")
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(pattern);
            }
        }
        //static void swap(int x, int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;

        //}
        static void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;

        }
        //function
        static int sumarray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];


            }
         return sum;
        

        }
        static int sumarr(ref int[] arr)
        {
            int sum = 0;
            if (arr is not null) 
            {
                arr = new int[3] { 100, 200, 300 };
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];


                }  
            }
            return sum;


        }
        //return 2
        static void MultiplySum(int x, int y,out int Sum , out int  Multiply)
        {
            Sum = x + y;
            Multiply = x * y;
        }
         //params
         static int Sum(params int[] Arr)
        {
            int sum = 0;    
           if (Arr is not null)
            {
                 for(int i = 0;i < Arr.Length;i++)
            {
                    sum += Arr[i];
            }
            }
            return sum;
        }
        //static void Dosome()
        //{
        //    int x=int.Parse(Console.ReadLine());
        //    int y=int.Parse(Console.ReadLine());
        //    int Division = x / y;
        //    Console.WriteLine(Division);
        //    int[] arr = { 1, 2, 3, 4, 5, 6 };
        //    arr[100] = 10;

        //}

        static void DosomePrimitive()
        {
            int X;
            bool flag;
            do
            {
                Console.WriteLine("Please, Enter X");
                flag = int.TryParse(Console.ReadLine(), out X); 



            } while (!flag);

            int Y;
            bool flag1;
            do
            {
                Console.WriteLine("Please, Enter Y");
                flag1 = int.TryParse(Console.ReadLine(), out Y);



            } while (!flag1 || Y <=0);

            int Division = X / Y;
            Console.WriteLine(Division);

            int[] Arr = { 1, 2, 3 };
            if (Arr is not null)
            {
                try
                {
                    Arr[1] = 10;
                }
                catch (Exception e){ 
                Console.WriteLine(e.Message);
                
                }
                finally
                {
                   
                    //Release , Remove , Deallocate UnManaged rousrces [DB,Files]
                    Console.WriteLine("Thnks, Byee !");
                }
            }

        }
        static void Main(string[] args)
        {


            #region 1-Judged Array
            //int[][]marks=  new int[3][];
            //marks[0] = new int[3] { 10, 20, 30 };
            //marks[1] = new int[2] { 10, 20};
            //marks[2] = new int[1] { 50 };

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    for (int j = 0; j < marks[i].Length; j++)
            //    {
            //        Console.Write(marks[i][j] + "  ");

            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 2 - Judged Array Part 2
            //Console.Write("Please,Enter size of judget Array: ");
            //int size=int.Parse(Console.ReadLine());
            //int[][]marks = new int[size][];
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine("Enter The number of subject in student" +(i+1));
            //    int SizeTwo = int.Parse(Console.ReadLine());    
            //    for (int j = 0; j < SizeTwo; j++)
            //    {
            //        Console.Write($"Enter grade number {j+1} :  ");
            //         int.TryParse(Console.ReadLine(),out marks[i][j] );


            #endregion

            #region 3 - Arrray Methods
            //int[] numbers = new int[] { 70, 50, 3,5, 1, 4 };
            //int[] numbers2 = new int[5];
            //Array.Sort(numbers); //sort asc
            //Array.Reverse(numbers); //sort desc
            //  Array.Copy(numbers, numbers2, 3);
            //Array.ConstrainedCopy(numbers, 2, numbers2, 0,3);
            // Console.WriteLine(Array.IndexOf(numbers,50)); // to display first index of value if it has redandansy.
            // Console.WriteLine(Array.LastIndexOf(numbers,50));
            //int[]arr = (int[]) Array.CreateInstance(typeof(int[]), 4);
            //int[,] arrs = (int[,])Array.CreateInstance(typeof(int[,]), 5/*row*/,6/*colum*/);

            //numbers.CopyTo(numbers2, 0);
            //numbers.SetValue(80, 4);
            //Console.WriteLine(numbers.GetValue(0));

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region  4 - Boxing & UnBoxing
            //Boxing  Casting from value type to reference type
            // Boxing  Casting from reference type to value type.
            //object obj = new object();
            //obj = "Gaber"; //Reference type 
            //obj = 15;
            //// 	//Implicit casting from int to obj [safe]
            //obj = true;
            //obj = 13.5;
            //obj = new DateTime();
            ////Animal  = dog

            //int X = 15;
            //object obj = 10;
            ////obj = "Gaber";
            //X = (int)obj; // Explicit casting [unsafe]
            //              //Dog = animal
            #endregion

            #region 5 - Nullable Types & Null Coelascing Operator Cont
            //String? name = null;
            //int number = null;
            //int[] Numbers;
            //Numbers = null;
            //===================
            //int? Num =10;
            //Num = null;
            //double?  Salary = 100.5;
            //Salary = null;
            //int X = 5;
            //int ? Y = 10;
            //Y=X;
            // int ? X= 10;
            //Y=null;
            //int y=(int)X;
            //if (X!=null)
            //y=(int)X;
            //else 
            //Y = 0;
            //Console.WriteLine (Y);
            //int X=0;
            //int Y ;
            //if (X is not null)
            //Y=(int)X;
            //else
            //Y = 0;
            //Console.Write(Y);
            ///********************************************/
            //if(X.HasValue)
            //{
            //Y= (int)X;
            //}
            //else 
            //{
            //Y=0;
            //}
            //Y= X is not null ? (int)X:0;
            //Console.WriteLine(Y);
            ////-=====
            //Y=X ?? 0;
            //Console.WriteLine(Y);

            #endregion


            #region 6 - Null Propagation Operator & Null Forgiving Operator
            //  double Salary = default;
            //    Console.WriteLine(Salary);  
            //int[] Arr;
            //Arr = default;

            ////for (int i = 0;(Arr is not null)&& i < Arr.Length; i++)
            ////{
            ////    Console.WriteLine(Arr[i]);

            ////}

            //for (int i = 0; i < Arr?.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);

            //}
            //Employee {Id, Name, Department}
            //Department {Dep_id , DeptName}
            //int[] Numbers = { 2, 3, 4, 5, 6, 7, 8, };
            //Numbers = null;
            // Console.WriteLine(Numbers?.Length);
            //// null forgeviness operator --> !
            //string name = null!;

            //Console.ReadKey();
            #endregion

            #region 7 - Functions
            //  printShape(5,@"/+_+\");
            // printShape(5);



            // Console.Write("Gaber\n Ezzat");
            //Console.Write("Gaber\tEzzat");
            // Console.WriteLine(@"sdsdsds\dsdsds\dssds\dssd"); 

            #endregion

            #region 8 - Function - Value Type Parameter
            //passing by value

            //int x = 5;
            //int y = 7;
            //Console.WriteLine("X -->" + x);
            //Console.WriteLine("Y -->" + y);
            //Console.WriteLine("==============");
            //swap(x, y);
            //Console.WriteLine("X -->" + x);
            //Console.WriteLine("Y -->" + y);
            //passing by ref
            //int x = 5;
            //int y = 7;
            //Console.WriteLine("X -->" + x);
            //Console.WriteLine("Y -->" + y);
            //Console.WriteLine("=======AfterSwap=======");
            //swap(ref x,ref y);
            //Console.WriteLine("X -->" + x);
            //Console.WriteLine("Y -->" + y);
            #endregion

            #region 9 - Function - Reference Type Parameter Part 1
            //by value
            //int[] numbers = { 1, 2, 7, 8, 9 };
            //int result = sumarray(numbers);
            //Console.WriteLine(result);
            //by ref
            //int[] number = { 1, 2, 7, 8, 9 };
            //int resul = sumarr(ref number);
            //Console.WriteLine(resul);

            #endregion

            #region 10 - Function - Reference Type Parameter Part 2
            //  int[] numbers = { 1, 2, 3 };
            //  int result = sumarr(numbers);
            ////  Console.WriteLine(result);
            //  Console.WriteLine(numbers[0]);

            //int[] numbers = { 1, 2, 3 };
            //int result = sumarr(ref numbers);
            ////  Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);


            #endregion

            #region 11 - Function - Passing By Out
            //int A = 10;
            //int B = 5;
            //int Sum, Multiply;
            //MultiplySum(A, B, out Sum, out Multiply);
            //Console.WriteLine(Sum);
            //Console.WriteLine(Multiply);


            #endregion

            #region 12 - Params
            // int[] Numbers = { 10, 20, 30 };
            //int Result = Sum(10,20,30);
            //Console.WriteLine(Result);  
            #endregion

            #region 13 - Exception Handling

            // Dosome();
           // DosomePrimitive();



            #endregion

        }
    }
}
