using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_oop2
{
    internal class hiring_date
    {
        private DateTime date;

        public HireDate(int year, int month, int day)
        {
            date = new DateTime(year, month, day);
        }

        public int Day
        {
            get { return date.Day; }
        }

        public int Month
        {
            get { return date.Month; }
        }

        public int Year
        {
            get { return date.Year; }
        }

        public override string ToString()
        {
            return date.ToString("d");
        }


    }
}
