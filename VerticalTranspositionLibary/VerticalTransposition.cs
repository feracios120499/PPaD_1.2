using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerticalTranspositionLibary
{
    public class VerticalTransposition
    {
        private int[] keyArray;
        private string key;

        public string Key
        {
            get { return key; }
            set
            {
                if (value.Distinct().Count() != value.Length)
                    throw new ArgumentOutOfRangeException("В ключе не должны повторятся символы");
                key = value;
                keyArray = new int[key.Length];

                var tempStr = value.OrderBy(p=>p).ToArray();

                for (int i = 0; i < keyArray.Length; i++)
                {
                    keyArray[i] = value.IndexOf(tempStr[i]);
                }
            }
        }

        public string Encrypt(string originalStr)
        {
            originalStr = originalStr.PadRight((originalStr.Length % keyArray.Length)*keyArray.Length,'/');

            var matrix = CreateMatrix(originalStr);
            //ShowMatrix(matrix);
            var encryptStr = string.Empty;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    var newI = j;
                    var newJ = GetIndex(i);
                    encryptStr += matrix[newI, newJ];
                }
            }
            return encryptStr;
        }
        public string Decrypt(string encryptStr)
        {
            var matrix = CreateMatrixEncrypt(encryptStr);
            var originalStr = string.Empty;
            //ShowMatrix(matrix);
            var tempArr = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {

                    var newI = j;
                    var newJ = GetIndex(i);
                    tempArr[j,i] = matrix[newI, newJ];
                }
            }
            for (int i = 0; i < tempArr.GetLength(0); i++)
            {
                for (int j = 0; j < tempArr.GetLength(1); j++)
                {
                    originalStr += tempArr[i, j];
                }
            }
            return originalStr.Replace("/", ""); ;
        }

        private char[,] CreateMatrix(string str)
        {
            var result = new char[str.Length/key.Length, key.Length] ;
            var index = 0;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = str[index];
                    index++;
                }
            }
            return result;
        }
        private char[,] CreateMatrixEncrypt(string str)
        {
            var result = new char[str.Length / key.Length, key.Length];
            var index = 0;
            for (int i = 0; i < result.GetLength(1); i++)
            {
                for (int j = 0; j < result.GetLength(0); j++)
                {
                    result[j, i] = str[index];
                    index++;
                }
            }
            return result;
        }
        private int GetIndex(int value)
        {
            for (int i = 0; i < keyArray.Length; i++)
            {
                if (keyArray[i] == value)
                    return i;
            }
            throw new KeyNotFoundException();
        }


    }
}
