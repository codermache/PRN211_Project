using System;
using System.Collections.Generic;

namespace Program.Models
{
    public partial class TimeSlot
    {
        public TimeSlot()
        {
            BookablePeriods = new HashSet<BookablePeriod>();
            Reservations = new HashSet<Reservation>();
        }

        public int SlotId { get; set; }
        public TimeSpan? FromTime { get; set; }
        public TimeSpan? ToTime { get; set; }

        public virtual ICollection<BookablePeriod> BookablePeriods { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return SlotId.ToString();
        }
    }
}
