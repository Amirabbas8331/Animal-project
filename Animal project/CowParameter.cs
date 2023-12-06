using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_project
{
    public class CowParameter<T>
    {
        public HealthParameters<int>? TimetoStand;
        public HealthParameters<int>? TimeToDeal;
        public HealthParameters<int>? TimetoRelax;
        public HealthParameters<int>? NumberOfMeal;
        public HealthParameters<int>? NumberOfMilkProduction;
        public DateOnly Date;
        public void Tostring()
        {
            CowParameter<T> en1 = new CowParameter<T>();
            Console.WriteLine(en1.ToString());
        }
    }
}
