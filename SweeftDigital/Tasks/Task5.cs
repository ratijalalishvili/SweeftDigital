using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigital.Tasks
{
    public static class Task5
    {
        static int variants = 0;
        public static int countVariants(int stairCount)
        {

            if (stairCount - 2 == 0)
            {
                variants++;
                
            }
            else if(stairCount -2 > 0)
            {
                countVariants(stairCount - 2);
            }

            if (stairCount -1 == 0)
            {
                variants++;
                            
            }
            else if(stairCount -1 >0)
            {
                countVariants(stairCount - 1);
            }
                        
                return variants;
            
        }
    }
}
