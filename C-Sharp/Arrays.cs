using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Arrays
    {
        public Arrays()
        {
            Console.WriteLine("-------------------Arrays--------------------");
            //Single-Dimensional Array.
            int[] arr1 = new int[10] { 10, 22, 45, 14, 16, 98, 78, 56, 52, 9 };
            int[] arr = new int[10];
            int n = arr1.Length, sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr1[i];
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
            //Multi-Dimensional Array.
            int[,] arr2 = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int a = arr2.GetLength(0), b = arr2.GetLength(1);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"a: {a}, b: {b}");
            //Jagged Array.
            int[][] arr3 = new int[2][];
            arr3[0] = new int[3] { 1, 2, 3 };
            arr3[1] = new int[5] { 4, 5, 6, 7, 8 };
            //Another Method of Implementation.
            /*int[][] arr3 = new int[2][]{
                new int[] {0,1,2,3,4},
                new int[] { 0, 1, 2 }
            };*/
            for(int i=0; i<arr3.Length; i++)
            {
                for(int j=0; j < arr3[i].Length; j++)
                {
                    Console.Write(arr3[i][j] + " ");
                }
                Console.WriteLine();
            }
            //Array Classes.
            Array.Sort(arr1); printArray(arr1);
            Array.Copy(arr1, arr, arr1.Length); printArray(arr);
            Array.Reverse(arr); printArray(arr);
            Console.WriteLine(Array.IndexOf(arr, 10));
            Console.WriteLine(Array.BinarySearch(arr1, 10));
        }
        public void printArray(int[] arr)
        {
            int n = arr.Length;
            for(int i=0; i<n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        //Params Array.
        public void show(params int[] arr)
        {
            int n = arr.Length;
            for(int i=0; i<n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public void show(params object[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
