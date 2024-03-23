using System;
using System.Collections.Generic;

namespace Lab_Reservation_System.Models
{
    public partial class Lab
    {
        public Lab()
        {
            BookablePeriods = new HashSet<BookablePeriod>();
            Reservations = new HashSet<Reservation>();
        }

        public int LabId { get; set; }
        public string? LabAddress { get; set; }
        public int? NoComputers { get; set; }

        public virtual ICollection<BookablePeriod> BookablePeriods { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
