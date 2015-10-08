using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCodingClasses
{
    public class Truck : Vehicle
    {
        public int NumberWheels
        {
            get { return 4; }

            //    public Truck (int wheels)
            //    {
            //    Wheels = wheels;
            //}
        }

        public string Horn()
        {
            return "Honk";
        }
}
