using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_project
{
    public abstract class Animal
    {
        public abstract DateTime BirthDay { get; init; }
        public static readonly int MaxLife;
        public List<Environment>? environment;
        public float Weight;
        public bool gender;
        public string? Name;
        public float StressFactor()
        {
            return 2.3F;
        }
        public int Life()
        {
            return 5;
        }
        public float KillPriority()
        {
            return 5.8F;
        }
        public int CostPerDay()
        {
            return 10;
        }
        public int ValuePerDay()
        {
            return 15;
        }


    }
}
