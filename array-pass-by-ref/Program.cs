using System;

class Program
{
    static void Main(string[] args) {
            
            int[] arr = new int[] { 2, 5, 8, 9, 10, 6, 9 };
            Power2(arr); //passing by reference or by value ? --> if whole array then it is by reference

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            

        }
        static void Power2 (int [] arrV)
        {
            for(int i = 0; i < arrV.Length; i++)
            {
                arrV[i] = arrV[i] * arrV[i];
             }
        }

}











