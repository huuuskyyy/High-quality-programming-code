using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCode
{
    class Program
    {
        Potato potato;
        //... 
        if (potato != null) 
        {
            if(potato.HasBeenPeeled && !potato.IsRotten)
            {
                 Cook(potato);
            }
        }
        
        bool isBiggerThanMinX = x >= MIN_X;
        bool isLessThanMaxX = x =< MAX_X;
        bool isBiggerThanMinY = y >= MIN_Y;
        bool isLessThanMaxY = y =< MAX_Y;
        bool isInRange = isBiggerThanMinX && isLessThanMaxX && isBiggerThanMinY && isLessThanMaxY;

        if (isInRange && canVisitCell)
        {
           VisitCell();
        }

	   

    }
}
