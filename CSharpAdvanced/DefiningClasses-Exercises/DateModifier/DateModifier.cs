using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class DateModifier
    {
        public DateTime Modified { get; set; }

        public double CalculateDaysDifference(string firstDate, string secondDate)
        {
            DateTime firstDateTime = DateTime.Parse(firstDate);
            DateTime secondDateTime = DateTime.Parse(secondDate);

            int endDate = DateTime.Compare(firstDateTime, secondDateTime);

            DateTime endDateTime = DateTime.Today;
            DateTime startDateTime = DateTime.Today;

            if (endDate >= 0)
            {
                endDateTime = firstDateTime;
                startDateTime = secondDateTime;
            }
            else
            {
                endDateTime = secondDateTime;
                startDateTime = firstDateTime;
            }

            return (endDateTime - startDateTime).TotalDays;
        }
    }
}
