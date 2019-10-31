using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlmaAPI
{
    public class weatherCond
    {
        
    public class temp
    {
        public double day { get; set; }
    }
        public class weather
    {

        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }

    }
    public class city { 
        public string name { get; set; }
    }
    public class list
    {

        public List<weather> weather { get; set; }
    }
}
}
