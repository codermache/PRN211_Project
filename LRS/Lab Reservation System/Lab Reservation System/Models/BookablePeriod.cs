using System;
using System.Collections.Generic;

namespace Lab_Reservation_System.Models
{
    public partial class BookablePeriod
    {
        public int LabId { get; set; }
        public string WeekDay { get; set; } = null!;
        public int SlotId { get; set; }
        public int? NoAvailableComputers { get; set; }

        public virtual Lab Lab { get; set; } = null!;
        public virtual TimeSlot Slot { get; set; } = null!;
        public virtual WeekDay WeekDayNavigation { get; set; } = null!;
    }
}
