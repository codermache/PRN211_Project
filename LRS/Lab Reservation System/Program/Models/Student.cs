using System;
using System.Collections.Generic;

namespace Program.Models
{
    public partial class Student
    {
        public Student()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int StdId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
