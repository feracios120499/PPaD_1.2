using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalSquareLibrary
{
    public class MagicalSquare
    {
        private int[] key;

        public string Encrypt(string originalStr)
        {
            key = new int[originalStr.Length];
            for (int i = 0; i < key.Length; i++)
            {
                key[i] = i;
            }
            Random random = new Random();
            for (int i = key.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = key[j];
                key[j] = key[i];
                key[i] = temp;
            }
            var encodeStr = string.Empty;
            for (int i = 0; i < key.Length; i++)
            {
                encodeStr += originalStr[key[i]];
            }
            return encodeStr;
        }
        public string Decrypt(string encodeStr)
        {
            var originalStr=new char[encodeStr.Length];
            
            for (int i = 0; i < key.Length; i++)
            {
                originalStr[key[i]] = encodeStr[i];
            }

            return string.Join("", originalStr.Select(p => p));
        }
    }
}
