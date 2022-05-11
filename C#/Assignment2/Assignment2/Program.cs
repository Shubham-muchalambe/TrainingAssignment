using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int[] ar = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("the elements at " + i);
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the elements are");
            for (int i = 0; i < ar.Length; i++)
            {

                Console.Write(ar[i] + " ");
            }
            Console.WriteLine("\nthe average of elements: " + ar.Average());
            Console.WriteLine("the min element: " + ar.Min() + " " + "and " + "the max element: " + ar.Max());

            //marks
            Console.WriteLine("\nEnter marks");
            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("the elements at " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("the elements are");
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(arr[i] + " ");
            }

            //asscending 
            Array.Sort(arr);
            Console.WriteLine("\narray after sort in ascending order...");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            //descending
            Array.Reverse(arr);
            Console.WriteLine("\narray after sort in descending order...");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }



            Console.WriteLine("\nthe sum of elements: " + arr.Sum() + " " + "and " + "the average of element: " + arr.Average());
            Console.WriteLine("\nthe min element: " + arr.Min() + " " + "and " + "the max element: " + arr.Max());






            //accept and display String
            Console.WriteLine("\nEnter a String");
            String s1 = Console.ReadLine();
            Console.WriteLine("the given input: " + s1 + " " + "\n " + "the length of string: " + s1.Length);

            //String reverse

            Console.WriteLine("\nEnter a String");
            String s2 = Console.ReadLine();
            String revs = "";
            for (int i = s2.Length - 1; i >= 0; i--)
            {
                revs += s2[i].ToString();

            }
            Console.WriteLine("the reversed String: " + revs);

            //===string values equal==
            Console.WriteLine("\nenter 6th string ");
            String s6 = Console.ReadLine();
            Console.WriteLine("enter 7th string ");
            String s7 = Console.ReadLine();
            if (s6 == s7)
            {
                Console.WriteLine("string s6 {0} and string s7 {1} are equal ", s6, s7);
            }
            else
            {
                Console.WriteLine("string s6 {0} and string s7 {1} are not equal ", s6, s7);
            }


            //palindrome
            Console.WriteLine("\nEnter a String");
            String s = Console.ReadLine();
            String rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i].ToString();
            }
            if (rev == s)
            {
                Console.WriteLine("the String is {0} and reversed string is {1} ", s, rev);
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }

            Console.ReadLine();
        }
    }
}

