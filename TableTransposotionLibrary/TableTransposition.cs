using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTransposotionLibrary
{
    public class TableTransposition
    {
        public string Encrypt(string originalStr)
        {
            //if (originalStr.Length > 20)
            //    throw new ArgumentOutOfRangeException(nameof(originalStr));
            

            var cipheredString = string.Empty;

            var newMatrix = ReverseMatrix(CreateMatrix(originalStr));
            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    var newI = i;
                    var newJ = (newMatrix.GetLength(1) - 1) - j;
                    cipheredString += newMatrix[newI, newJ];
                }
            }
            return cipheredString;
        }
        public string Decrypt(string encryptStr)
        {
            var orignalStr = string.Empty;

            var newMatrix = ReverseMatrix(CreateMatrixEncrypt(encryptStr));
            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    var newI = i;
                    var newJ = (newMatrix.GetLength(1) - 1) - j;
                    orignalStr += newMatrix[newI, newJ];
                }
            }
            
            return new String(orignalStr.Reverse().ToArray()).Replace("/","");
        }
        private char[,] CreateMatrix(string originalStr)
        {
            var countColumns = Convert.ToInt32(Math.Ceiling(Math.Sqrt(originalStr.Length)));
            var countRows = Convert.ToInt32(Math.Ceiling(Math.Sqrt(originalStr.Length)));
            var result = new char[countRows, countColumns];
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
        private char[,] CreateMatrixEncrypt(string originalStr)
        {
            var countRows = Convert.ToInt32(Math.Floor(Math.Sqrt(originalStr.Length)));
            var countColumns = Convert.ToInt32(Math.Ceiling(Math.Sqrt(originalStr.Length)));
            var result = new char[countRows, countColumns];
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
        private char[,] ReverseMatrix(char[,] originalMatrix)
        {
            var result = new char[originalMatrix.GetLength(1), originalMatrix.GetLength(0)];

            for (int i = 0; i < originalMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < originalMatrix.GetLength(1); j++)
                {
                    result[j, i] = originalMatrix[i, j];
                }
            }
            return result;
        }
    }
}
