using System;

namespace Methods
{
    class Program
    {
        #region Task1
        //1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
        //static void Main(string[] args)
        //{
        //    int a = 21;
        //    int b = 42;

        //    work1(a, b);
        //}
        //public static void work1(int n, int m)
        //{
        //    if (checknum(n, m))
        //    {
        //        Console.WriteLine("numbers are divide 3 and 7");
        //    }
        //    else
        //    {
        //        Console.WriteLine("numbers are not divide 3 and 7");
        //    }
        //}

        //public static bool checknum(int n, int m)
        //{
        //    if (n % 3 == 0 && m % 3 == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        #endregion


        #region Task2
        //2) n və m ədədləri verilir.Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
        //static void Main(string[] args)
        //{
        //    int a = 68;
        //    int b = 77;

        //    Sum(a, b);
        //}
        //public static void Sum(int n, int m)
        //{
        //    int result = 0;
        //    if (CheckNumEven(n, m))
        //    {
        //        Console.WriteLine(result = n + m);
        //    }
        //    else
        //    {
        //        Console.WriteLine("n or m numbers are odd");
        //    }
        //}
        //public static bool CheckNumEven(int n, int m)
        //{
        //    if (n % 2 == 0 && m % 2 == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        #endregion


        #region Task3
        //3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.
        //static void Main(string[] args)
        //{
        //    int a = 12;
        //    int b = 30;
        //    Console.WriteLine(CountOddNum(a, b));
        //}
        //public static int CountOddNum(int n, int m)
        //{
        //    int count = 0;
        //    for (int i = n; i < m; i++)
        //    {
        //        if (i % 2 == 1)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}



        #endregion


        #region Task4
        //4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
        //static void Main(string[] args)
        //{
        //    int a = 12;
        //    int b = 17;
        //    Console.WriteLine(SumOddNum(a, b));
        //}
        //public static int SumOddNum(int n, int m)
        //{
        //    int sum = 0;
        //    for (int i = n; i < m; i++)
        //    {
        //        if (i % 2 != 0)
        //        {
        //            sum += i;
        //        }
        //    }
        //    return sum++;
        //}
        #endregion


        #region Task5
        //5)Verilmish arrayin icindeki tek ededlerin cemini tapin.
        //static void Main(string[] args)
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    Console.WriteLine(ArrSumOddNum(arr));
        //}
        //public static int ArrSumOddNum(int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 2 == 1)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}
        #endregion


        #region Task6
        //6)Verilmish arrayin icindeki cut ededlerin sayini tapin.
        //static void Main(string[] args)
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    Console.WriteLine(ArrCountEvenNum(arr)); 
        //}
        //public static int ArrCountEvenNum(int[] arr)
        //{
        //    int count = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 2 == 0)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        #endregion


        #region Task7
        //7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
        //static void Main(string[] args)
        //{
        //    int a = 23;
        //    Console.WriteLine(PrimeCompositeNum(a));
        //}
        //public static string PrimeCompositeNum(int n)
        //{
        //    if (n <= 1)
        //    {
        //        return "This number neither prime nor composite";
        //    }
        //    else if (n == 2 || n == 3 || n == 5 || n == 7)
        //    {
        //        return "This number is prime";
        //    }
        //    else if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0 || n % 7 == 0)
        //    {
        //        return "This number is composite";
        //    }
        //    else
        //    {
        //        return "This number is prime";
        //    }
        //}
        //public static bool CheckPC(int n)
        //{
        //    if (n <= 1)
        //    {
        //        return true;
        //    }
        //    else if (n == 2 || n == 3 || n == 5 || n == 7)
        //    {
        //        return true;
        //    }
        //    else if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0 || n % 7 == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        #endregion


        #region Task8
        //8) n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın
        //static void Main(string[] args)
        //{
        //    int a = 64;
        //    Console.WriteLine(Multi(a));
        //}
        //public static string Multi(int n)
        //{
        //    int i = 2;
        //    while (i < n)
        //    {
        //        i *= 2;

        //    }
        //    if (n < 1)
        //    {
        //        return "Please enter correct number" ;
        //    }
        //    else if (n == i)
        //    {
        //        return "Equal";
        //    }
        //    else
        //    {
        //        return "Not Equal";
        //    }
        //}
        #endregion


        #region Task9
        //9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.
        //static void Main(string[] args)
        //{
        //    int[] arr = { 2, 3, 20, 1, 23, 54, 4, 5, 9, 0 };
        //    Console.WriteLine(ArrMulti(arr)); 
        //}
        //public static int ArrMulti(int[] arr)
        //{
        //    int sq = 1;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > 1 && arr[i] < 20)
        //        {
        //            sq *= arr[i];
        //        }
        //    }
        //    return sq;
        //}
        #endregion


        #region Task10
        //10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
        //static void Main(string[] args)
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    Console.WriteLine(ArrEvenSumSq(arr));
        //}
        //public static int ArrEvenSumSq(int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 2 == 0)
        //        {
        //            sum += arr[i];

        //        }
        //    }
        //    sum *= sum;
        //    return sum;
        //}
        #endregion
    }
}

