using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkQueue
{
    public class Car
    {
        public string imageUrl { get; set; }
        public int carType { get; set; }
        public int id { get; set; }
        public int parkedTime { get; set; }
        public int exitTime { get; set; }

        public Car(int carType, int exitTime)
        {
            this.carType = carType;
            this.exitTime = exitTime;
            this.imageUrl = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\assets\img\cars\car-" + carType + ".png");
        }

    }
}
