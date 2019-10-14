using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleTranspositionLibrary
{
    public class DoubleTransposition
    {
        private int[] rowKey;
        private int[] columnKey;


        public string Encrypt(string originalStr)
        {
            int size = Convert.ToInt32(Math.Ceiling(Math.Sqrt(originalStr.Length)));

            rowKey = new int[size];
            columnKey = new int[size];

            for (int i = 0; i < size; i++)
            {
                rowKey[i]=i;
                columnKey[i]=i;
            }

            Random random = new Random();
            for (int i = rowKey.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = rowKey[j];
                rowKey[j] = rowKey[i];
                rowKey[i] = temp;
            }
            random = new Random();
            for (int i = columnKey.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = columnKey[j];
                columnKey[j] = columnKey[i];
                columnKey[i] = temp;
            }

            var matrix = CreateMatrix(originalStr);
            var encodeStr = string.Empty;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    encodeStr += matrix[columnKey[i], rowKey[j]];

                }
            }
            return encodeStr;
        }

        public string Decrypt(string encodeStr)
        {
            var matrix = CreateMatrix(encodeStr);
            var resultMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    resultMatrix[columnKey[i], rowKey[j]] = matrix[i, j];
                }
            }
            var originalStr = string.Empty;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    originalStr += resultMatrix[i, j];
                }
            }
            return originalStr.Replace("/","");
        }
        private char[,] CreateMatrix(string originalStr)
        {
            var size = Convert.ToInt32(Math.Ceiling(Math.Sqrt(originalStr.Length)));
            var result = new char[size, size];
            var index = 0;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (index >= originalStr.Length)
                        result[i, j] = '/';
                    else
                        result[i, j] = originalStr[index];
                    index++;
                }
            }
            return result;
        }

    }
}
