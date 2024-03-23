using System;
using System.Collections.Generic;

namespace Program.Models
{
    public partial class Reservation
    {
        public int LabId { get; set; }
        public string WeekDay { get; set; } = null!;
        public int SlotId { get; set; }
        public int StdId { get; set; }

        public virtual Lab Lab { get; set; } = null!;
        public virtual TimeSlot Slot { get; set; } = null!;
        public virtual Student Std { get; set; } = null!;
        public virtual WeekDay WeekDayNavigation { get; set; } = null!;
    }
}
