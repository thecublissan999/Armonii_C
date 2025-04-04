using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationMap
{
    public class Local
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

}
