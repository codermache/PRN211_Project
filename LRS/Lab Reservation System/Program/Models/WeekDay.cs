using System;
using System.Collections.Generic;

namespace Program.Models
{
    public partial class WeekDay
    {
        public WeekDay()
        {
            BookablePeriods = new HashSet<BookablePeriod>();
            Reservations = new HashSet<Reservation>();
        }

        public string WeekDay1 { get; set; } = null!;
        public DateTime? Date { get; set; }

        public virtual ICollection<BookablePeriod> BookablePeriods { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return WeekDay1;
        }

    }
}
