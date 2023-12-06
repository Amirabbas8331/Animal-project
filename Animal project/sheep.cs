using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_project
{
    public class Sheep : Animal, IComparable, IEnumerable
    {
        public override DateTime BirthDay { get; init; }
        public static int Number;
        public static readonly int MaxLife;
        public List<Environment>? environment;
        public List<SheepParameter<int>>? shp;
        public void Tostring()
        {
            Sheep sheep = new Sheep();
            Console.WriteLine(sheep.ToString());
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
