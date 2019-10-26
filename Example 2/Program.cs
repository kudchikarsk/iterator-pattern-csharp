using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        public class Weeks
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

            public IEnumerable GetWeeksIterator()
            {
                return new WeeksIterator(weeks);
            }

            public IEnumerable GetWeekDaysIterator()
            {
                return new WeekDaysIterator(weeks);
            }
        }

        public class WeeksIterator : IEnumerator, IEnumerable
        {
            private readonly string[] weeks;
            private int position;

            public WeeksIterator(string[] weeks)
            {
                this.weeks = weeks;
                this.position = -1;
            }

            public object Current => weeks[position];

            public bool MoveNext()
            {
                if (++position == weeks.Length) return false;
                return true;
            }

            public void Reset()
            {
                this.position = -1;
            }

            public IEnumerator GetEnumerator()
            {
                return this;
            }
        }

        public class WeekDaysIterator : IEnumerator, IEnumerable
        {
            private readonly string[] weeks;
            private int position;

            public WeekDaysIterator(string[] weeks)
            {
                this.weeks = weeks;
                this.position = -1;
            }

            public object Current => weeks[position];

            public bool MoveNext()
            {
                if (++position == (weeks.Length - 2)) return false;
                return true;
            }

            public void Reset()
            {
                this.position = -1;
            }


            public IEnumerator GetEnumerator()
            {
                return this;
            }
        }

        static void Main(string[] args)
        {
            var weeks = new Weeks();
            var iterator = weeks.GetWeeksIterator();
            foreach (var item in weeks.GetWeeksIterator())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
