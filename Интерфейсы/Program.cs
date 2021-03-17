using System;
using System.Collections.Generic;

namespace Интерфейсы
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new LadaSeven());
            cars.Add(new BMVSeven());

            foreach(var car in cars)
            {
               
                Console.WriteLine(car.Move(200));
            }

            Console.WriteLine();
            // явная реализация интерфеса
            Cyborg cyborg = new Cyborg();
            Console.WriteLine(((ICar)cyborg).Move(100));
            Console.WriteLine(((IPerson)cyborg).Move(100));

        }
    }
}
