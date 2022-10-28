using System;

namespace Search_Algorithm
{
    class Program
    {
        //Array to be searched
        int[] arr = new int[20];
        //Number of elements in the array
        int n;
        //get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of elements in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0)) && (n <= 20))
                        break;
                else
                    Console.
            }
        }
    }
}