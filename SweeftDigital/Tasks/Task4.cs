using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigital.Tasks
{
    public static class Task4
    {
        public static bool isProperly(string sequence)
        {
            /*სამ მოთხოვნას უნდა აკმაყოფილებდეს
            1. იწყებოდეს '(' - ით
            2. მთავრდებოდეს ')' - ით
            3. '(' ამ ფრჩხილების რაოდენობა ტოლი უნდა იყოს ')' ამ ფრჩხილების რაოდენობის
            */
            int leftBraces = 0;
            int rightBraces = 0;

            foreach(char x in sequence)
            {
                if (x == '(') { leftBraces++; }
                if (x == ')') { rightBraces++; }
            }

            if(sequence[0] == ')')
            {
                return false;
            }
            else if (sequence[sequence.Length - 1] == '(')
            {
                return false;
            }
            else if(leftBraces != rightBraces)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
