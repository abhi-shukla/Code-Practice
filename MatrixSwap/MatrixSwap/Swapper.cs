using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSwap
{
    public class Swapper
    {
        public bool Swap(int[,] matrix)
        {
            if (matrix.Rank == 0 || matrix.GetLength(0) != matrix.Rank+1)
            { 
                return false;
            }

            int n = matrix.Rank+1;

            for(int layer = 0; layer < n/2; layer++)
            {
                var first = layer;
                var last = n - 1 - layer;

                for(int i = first; i < last; i++)
                {
                    var offset = i - first;

                    // Save Top
                    int top = matrix[first,i];

                    // Left --> Top
                    matrix[first,i] = matrix[last - offset,first];

                    // Bottom --> Left
                    matrix[last - offset,first] = matrix[last,last - offset];

                    // Right --> Bottom
                    matrix[last,last - offset] = matrix[i,last];

                    // Saved -- Right
                    matrix[i,last] = top;
                }
            }

            return true;
        }
    }
}
