using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLessons.WorkingWithCollections
{
    internal class CollectionsTest
    {
        public void PrintCars()
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            List<Car> carList = new List<Car>();
            carList.Add(car1);
            carList.Add(car2);

            foreach (Car car in carList)
            {
                Console.WriteLine($"Make:  {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine();
            }
        }
    }
}
