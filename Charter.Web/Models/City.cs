using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charter.Web.Models
{
    public class City
    {
        public string Name { get; private set; }

        public City(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            this.Name = name;
        }
    }
}