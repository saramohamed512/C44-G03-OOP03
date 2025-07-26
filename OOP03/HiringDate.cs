using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class HiringDate
    {
        #region Attributes
        private int _day;
        private int _month;
        private int _year;
        #endregion

        #region Properties
        public int Day
        {
            get { return _day; }
            set
            {
                if (value < 1 || value > 31)
                    throw new ArgumentOutOfRangeException("Day must be between 1 and 31");
                _day = value;
            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException("Month must be between 1 and 12");
                _month = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1800 || value > DateTime.Now.Year)
                    throw new ArgumentOutOfRangeException($"Year must be between 1800 and {DateTime.Now.Year}");
                _year = value;
            }
        }
        #endregion

        #region Constructor
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // Default constructor 
        public HiringDate() : this(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year) { }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

       
        #endregion

    }

}
