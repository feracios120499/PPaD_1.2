using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockTranspositionLibrary
{
    public class BlockTranspostion
    {
        private int[] key = new int[] { 4, 1, 3, 2 };

        public string Encrypt(string originalStr)
        {
            var encryptStr = string.Empty;
            var blockSize = originalStr.Length / key.Length + (originalStr.Length % key.Length == 0 ? 0:1) ;

            originalStr = originalStr.PadRight(blockSize * key.Length, '/');
            var tempArr = new string[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                var startIndex = blockSize * i;
                tempArr[key[i]-1]= originalStr.Substring(startIndex, blockSize);
            }
            for (int i = 0; i < tempArr.Length; i++)
            {
                encryptStr += tempArr[i];
            }
            return encryptStr;
        }
        public string Decrypt(string decryptStr)
        {
            var originalStr = string.Empty;
            var blockSize = decryptStr.Length / key.Length + (decryptStr.Length % key.Length == 0 ? 0 : 1);

            var tempArr = new string[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                var startIndex = blockSize * (key[i]-1);
                tempArr[i] = decryptStr.Substring(startIndex, blockSize);
            }
            for (int i = 0; i < tempArr.Length; i++)
            {
                originalStr += tempArr[i];
            }
            return originalStr.Replace("/","");
        }
    }
}
