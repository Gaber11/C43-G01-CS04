namespace Demo
{
    internal class Program
    {
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

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

        }
    }
}
