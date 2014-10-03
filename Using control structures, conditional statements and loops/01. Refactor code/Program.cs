using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCode
{
    public void Cook();

    public class Chef
    {
         public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            
            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            Bowl bowl;
            bowl = GetBowl();

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {   
             //... 
        }
        private Carrot GetCarrot()
        {
             //...
        }
        private void Cut(Vegetable vegetable)
        {
             //...
        }  
   
        private Potato GetPotato()
        {
             //...
        }
    }
}
