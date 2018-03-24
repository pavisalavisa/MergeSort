using System;
using System.Diagnostics;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = getRandomInts(100000);
            Stopwatch s = new Stopwatch();
            s.Start();
            MergeSort(a, 0, a.Length-1);
            s.Stop();
            Console.WriteLine("It took " + s.Elapsed + " to sort array.\n");
            Console.ReadKey();
        }

        public static int[] getRandomInts(int howMuch)
        {
            int[] numbers = new int[howMuch];
            var rand = new Random();
            for (int i = 0; i < howMuch; i++)
            {

                numbers[i] = rand.Next(0,10000);

            }
            return numbers;
        }

        static void MergeSort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                MergeSort(A, p, q);
                MergeSort(A, q + 1, r);
                Merge(A, p, q, r);
            }
        }

        static void Merge(int []A,int p,int q,int r)
        {
            int[] B = new int[A.Length];
            int i, k, j;
            i = k = p;
            j = q + 1;
            while (i <= q && j <= r)
            {
                if (A[i] <= A[j]) B[k++] = A[i++];
                else B[k++] = A[j++];
            }
            while(i<=q) B[k++] = A[i++];
            while(j<=r) B[k++] = A[j++];
            for( i = p; i < r+1; i++)
            {
                A[i] = B[i];
            }
                
            
        }
        static void printArray(int[] A)
        {
            foreach(var x in A)
            {
                Console.WriteLine(x);
            }
        }
    }


    
}
