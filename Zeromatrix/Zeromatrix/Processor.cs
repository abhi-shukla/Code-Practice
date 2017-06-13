using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeromatrix
{
    public class Processor
    {
        public int[,] ZreoIn(int[,] matrix)
        {
            bool[] row = new bool[matrix.GetLength(0)];
            bool[] column = new bool[matrix.GetLength(1)];

            // Store the row and column which need to be nullfied
            for (int i = 0; i < row.Length; i++)
            {
                for (int j = 0; j < column.Length; j++)
                {
                    if(matrix[i, j] == 0)
                    {
                        row[i] = true;
                        column[j] = true;
                    }
                }
            }

            // Nullify Rows
            for(int i = 0; i < row.Length; i++)
            {
                if(row[i])
                {
                    for(int j = 0; j < column.Length; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            // Nullify Columns
            for(int i = 0; i < column.Length; i++)
            {
                if(column[i])
                {
                    for(int j = 0; j < row.Length; j++)
                    {
                        matrix[j, i] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}
