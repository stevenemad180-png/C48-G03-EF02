using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G03_EF02
{
    public class profile
    {
      public int Id { get; set; }
        public string? Biography { get; set; }
        public string? Website { get; set; }
        public string? Logo { get; set; }

        //one- one 
        public Organizer org { get; set; } = null!;
        public int orgId { get; set; }


    }

}
