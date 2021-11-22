using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigital.Tasks
{
    public static class Task1
    {
        public static bool isPalindrome(string text)
        {
            int length = text.Length;
            for (int i = 0; i < length; i++)
            {
                if (text[i] != text[length - 1-i])
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }

            return true;
        }
    }
}
