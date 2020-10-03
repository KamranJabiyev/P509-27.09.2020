using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //ReverseArr(new int[5] { 1,2,5,10,9});
            //int[] arr = { 20, 30, 40 };
            //ReverseArr(arr);
            #endregion

            #region Value & Referance types
            //int a = 5;
            //int b = a; //b=5 - equal
            //b = 6;
            //Console.WriteLine("a = "+a);
            //Console.WriteLine("b = " + b);

            //int[] arr = { 10, 20, 30,40 };
            //int[] arr1 = arr; //arr1={10,20,30} - non equal
            //int[] arr2 = arr1;

            //arr1[0] = 100;
            //Console.WriteLine("arr[0] ="+arr[0]);
            //Console.WriteLine("arr1[0] =" + arr1[0]);
            //Console.WriteLine("arr2[0] =" + arr2[0]);

            //int a = 10;
            //ChangeNum(a);
            //Console.WriteLine("a=" + a);

            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine("arr[0] =" + arr[0]);
            //ChangeIndex(arr);
            //Console.WriteLine("arr[0] =" + arr[0]);
            #endregion

            #region Out&Ref keywords
            //int a=10;
            //ChangeRef(ref a);
            ////ChangeOut(out a);
            //Console.WriteLine("a: "+a);

            //Console.WriteLine("Eded daxil edin:");
            //string number = Console.ReadLine();
            //int result;
            //bool r = int.TryParse(number,out result);
            //if (r)
            //{
            //    Console.WriteLine(result+10);
            //}
            //else
            //{
            //    Console.WriteLine("eded daxil etmediniz!!!");
            //}
            #endregion

            #region Array&string methods

            //int[] arr = { 5, 1, 37, 5, 45, 12 };
            //int[] a = new int[3] { 1, 2, 3 };
            //Console.WriteLine(arr.Length);
            //Array.Resize(ref arr, 6);
            //Console.WriteLine(arr.Length);
            //int[,] multiArr = { { 1, 2 }, { 3, 4 } };
            //Console.WriteLine(multiArr[1,1]);
            //Console.WriteLine(arr.Length);
            //Console.WriteLine(multiArr.Rank);
            //Array.Reverse(arr);
            //Array.Sort(arr);

            //Console.WriteLine(arr);
            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Sum());
            //Console.WriteLine(arr.Average());
            //Array.Clear(arr, 1, 2);
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] arr = { 5, 1, 37, 5, 45, 12 };
            //string test=String.Join("-", arr);
            //Console.WriteLine(test);
            //string word = "   Hello    "; // {'H','e','l','l','o'}
            //string result=word.Remove(2,1);
            //Console.WriteLine(result);
            //string result=word.Replace("ll", "aa");
            //Console.WriteLine(result);
            //Console.WriteLine(word[0]);
            //string str=word.Trim();
            //Console.WriteLine(word);
            //bool res=word.Contains("wo");
            //Console.WriteLine(res);
            //string sentence = "Hello Hi Bye";
            //string[] result=sentence.Split(' ');
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region StringBuilder
            //Salam P509 - malaS 905P
            // [Salam,P509,qrupu]

            string s = "Salam P509 qrupu";
            Console.WriteLine(ReverseWord(s));
            //StringBuilder sb = new StringBuilder();
            #endregion

        }

        static StringBuilder ReverseWord(string str)
        {
            StringBuilder result = new StringBuilder();
            string[] res = str.Split(' ');
            foreach (string word in res)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result.Append(word[i]);
                }
                if (word != res[res.Length - 1])
                    result.Append(" ");
            }
            return result;
        }

        //static string ReverseWord(string str)
        //{
        //    string result = "";
        //    string[] res = str.Split(' ');
        //    foreach (string word in res)
        //    {
        //        for (int i = word.Length-1; i >= 0; i--)
        //        {
        //            result += word[i];
        //        }
        //        if (word != res[res.Length - 1])
        //            result += " ";
        //    }
        //    return result;
        //}

        #region Out&Ref keywords
        //static void ChangeRef(ref int a)
        //{
        //    a = 100;
        //    Console.WriteLine("ref: "+a);
        //}

        //static void ChangeOut(out int a)
        //{
        //    a = 100;
        //    Console.WriteLine("out: " + a);
        //}
        #endregion

        #region Value & Referance types
        //static void ChangeIndex(int[] arr)
        //{
        //    arr[0] = 10;
        //    Console.WriteLine("method =" + arr[0]);
        //}

        //static void ChangeNum(int a)
        //{
        //    a = 100;
        //    Console.WriteLine("from method:" + a);
        //}
        #endregion


        #region Task
        //static void ReverseArr(int[] arr)
        //{
        //    for (int i = arr.Length-1; i >= 0; i--)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}
        #endregion

    }
}
