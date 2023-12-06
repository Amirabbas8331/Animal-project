using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_project
{
    public class SheepParameter<T>
    {
        public HealthParameters<int>? TimetoStand;
        public HealthParameters<int>? TimeToDeal;
        public HealthParameters<int>? TimetoRelax;
        public HealthParameters<int>? NumberOfMeal;
        public HealthParameters<int>? NumberOfMilkProduction;
        public DateOnly Date;
        public void Tostring()
        {
            SheepParameter<T> SHP = new SheepParameter<T>();
            Console.WriteLine(SHP.ToString());
        }
    }
}
