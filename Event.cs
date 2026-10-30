using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G03_EF02
{
    public class Event
    {
        //title,description,a start date,optional end date,maximumnumber of attendees allowed.
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }
        public int maximumNumberOfAttendees { get; set; }



        public Organizer organizer { get; set; } = null!;
        public int organizerId { get; set; }
    }

}
