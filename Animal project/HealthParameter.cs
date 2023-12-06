using System.Reflection;

namespace Animal_project
{
    public class HealthParameters<T>
    {
        public string? name;
        public T? Current;
        public T? Standard;
        public float StressFactor()
        {
            return 2.3F;
        }
        public void Tostring()
        {
            HealthParameters<T> HP = new HealthParameters<T>();
            Console.WriteLine(HP.ToString());
        }
    }
}
