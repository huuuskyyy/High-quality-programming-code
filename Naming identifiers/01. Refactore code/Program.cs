using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vehicle
{
    private const int MAX_TYRES = 6;

    public class TruckVehicle
    {
       public void IsTruckLoaded (bool isLoaded)
        {
            string isLoadedToString = isLoaded.ToString();
            Console.WriteLine(isLoadedToString);
        }
    }

    public static void Main()
    {
        Vehicle.TruckVehicle truck = new Vehicle.TruckVehicle();
        truck.IsTruckLoaded(true);
    }
}

