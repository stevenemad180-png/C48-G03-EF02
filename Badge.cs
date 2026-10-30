using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G03_EF02
{
    public enum BadgeTier
    {
        Standard,
        VIP
    }

    public class Badge
    {
        public int BadgeNumber { get; set; }

        public DateTime IssueDate { get; set; }

        public BadgeTier Tier { get; set; }


        public Attendee Attendee { get; set; } = null!;
        public int AttendeeId { get; set; }

    }
}
