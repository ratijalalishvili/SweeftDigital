using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigital.Tasks
{
    public static class Task3
    {
        public static int notContaints(int[] arr)
        {
            int integers = 1;

            for(int i = 0; ; i++)
            {
               if(arr[i] > 0 && arr[i] != integers)
                {
                    return integers;
                }
                else if(arr[i]<= 0)
                {
                    continue;
                }
                else
                {
                    integers++;
                }
            }
        }
    }
}
