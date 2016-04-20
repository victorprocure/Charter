using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charter.Web.Models
{
    public class User
    {
        public City Departure { get; private set; }
        public City Arrival { get; private set; }

        public void ChangeDeparture(City city)
        {
            if (city == null)
            {
                throw new ArgumentNullException(nameof(city));
            }

            this.Departure = city;
        }

        public void ChangeArrival(City city)
        {
            if (city == null)
            {
                throw new ArgumentNullException(nameof(city));
            }

            this.Arrival = city;
        }
    }
}