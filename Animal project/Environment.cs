using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Animal_project
{
    public class Environment
    {
        public HealthParameters<int>? TDS;
        public HealthParameters<int>? Temp;
        public HealthParameters<int>? Density;
        public HealthParameters<int>? DB;
        public HealthParameters<int>? AQI;
        public HealthParameters<int>? OX;
        public DateOnly Date;

        public void Tostring()
        {
            Environment en2 = new Environment();
            Console.WriteLine(en2.ToString());
        }

    }
    

}
