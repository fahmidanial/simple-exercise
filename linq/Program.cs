using System;

class Program
{


        static void Main(string[] args)
        {
            int[] arr = new int[]
            { 55, 10, 109, 102, 230, 11, 77, 55, 92, 250, 76, 102, 2, 32, 78, 67, 300, 102 };



            //Perform a LINQ query to find all the even values and display result of all the even values
            var evenlist = from val in arr
                           where val % 2 == 0
                           orderby val descending
                           select val;
            Console.WriteLine("Total even number in the list {0}. The even numbers in the list : ", evenlist.Count());
            foreach (var i in evenlist)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            var flist = from v in arr
                        where v > 100
                        select v;
            Console.WriteLine("Values above 100: ");
            foreach (var i in flist)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"The largest value : {flist.Max()}");
            Console.WriteLine($"The average value for the list: {flist.Average()}");

            //Perform the query to find value in between 1 to 50 using LINQ
            var list1_50 = from val in arr
                           where (val >= 1 && val <= 50)
                           orderby val ascending
                           select val;

            Console.WriteLine("Values between 1 to 50 : ");
            foreach (var value in list1_50)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            char[] ch = new char[] { 'a', 'h', 'b', 'k', 'l', 'p', 'q', 't', 'u', 'm', 'i' };

            var vowels = from c in ch
                         where isVowel(c)
                         select c;
            Console.WriteLine("The vowels in the list: ");
            foreach (var v in vowels)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();

        }
        static bool isVowel(char v)
        {
            bool ans;
            switch (v)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    ans = true;
                    break;
                default:
                    ans = false;
                    break;
            }
            return ans;
        }

    }


