using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCodingClasses
{
    public class Boat : Vehicle
    {
        public int NumberWheels
        {
            get { return 0; }

            //public Boat(int wheels) 
            //{
            //    Wheels = wheels;
            //}
        }

        public string Horn()
        {
            return "Honk";
        }
    }
}
