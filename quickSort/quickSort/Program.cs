using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {231,65,1,31,3,25,41,41,61,231 };
            quickSort(A, 0, A.Length - 1);
            for (int i = 0; i<A.Length; i++) {
                Console.WriteLine(A[i]);
            }
            
        }

        static void exchange(int[] A, int i, int j) {
            var temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        //p and r are zero-based number
        static int partition(int[] A, int p, int r) {
            var x = A[p];
            int i = p;
            for (int j = p+1; j<r+1; j++) {
                if (A[j] <= x) {
                    i++;
                    exchange(A, i, j);
                }
            }
            exchange(A, p, i);
            return i;
        }

        static void quickSort(int[] A, int p, int r)
        {
            if (p<r) {
                int q = partition(A,p,r);
                quickSort(A, p, q - 1);
                quickSort(A, q+1, r);
            }
        }
    }
}
