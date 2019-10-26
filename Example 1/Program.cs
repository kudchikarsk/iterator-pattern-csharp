using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
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

            public IWeeksIterator GetWeeksIterator()
            {
                return new WeeksIterator(weeks);
            }

            public IWeeksIterator GetWeekDaysIterator()
            {
                return new WeekDaysIterator(weeks);
            }
        }

        public interface IWeeksIterator
        {
            string Current { get; }

            bool MoveNext();
        }

        public class WeeksIterator : IWeeksIterator
        {
            private readonly string[] weeks;
            private int position;

            public WeeksIterator(string[] weeks)
            {
                this.weeks = weeks;
                this.position = -1;
            }

            public string Current => weeks[position];

            public bool MoveNext()
            {
                if (++position == weeks.Length) return false;
                return true;
            }
        }

        public class WeekDaysIterator : IWeeksIterator
        {
            private readonly string[] weeks;
            private int position;

            public WeekDaysIterator(string[] weeks)
            {
                this.weeks = weeks;
                this.position = -1;
            }

            public string Current => weeks[position];

            public bool MoveNext()
            {
                if (++position == (weeks.Length -2)) return false;
                return true;
            }
        }

        static void Main(string[] args)
        {
            var weeks = new Weeks();
            var iterator = weeks.GetWeekDaysIterator();
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
            Console.ReadLine();
        }
    }
}
