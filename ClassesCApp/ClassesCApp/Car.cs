using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCApp
{
    class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }

        public double DeterminMarketValue()        //This is the methods
        {
            double marketValue = 0;
            if (Year == "2011")
            {
                marketValue = 500.0;
            }
            else if (Year == "2012")
            {
                marketValue = 1000.0;
            }
            else if (Year == "2013")
            {
                marketValue = 2000.0;
            }
            else if (Year == "2014")
            {
                marketValue = 3000.0;
            }
            else if (Year == "2015")
            {
                marketValue = 4000.0;
            }

            return marketValue;
        }
    }
}
