using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    class Program
    {
        public class Weeks : IEnumerable
        {
            private string[] weeks = new string[]{
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
                };


            public IEnumerator GetEnumerator()
            {
                foreach (var item in weeks)
                {
                    yield return item;
                }
            }
        }

        static void Main(string[] args)
        {
            var weeks = new Weeks();
            foreach (var item in weeks)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
