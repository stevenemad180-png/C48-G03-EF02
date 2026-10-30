using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G03_EF02
{
    [Table("EventOrganizers")]

    public class Organizer
    {
        
            public int Id { get; set; }

            [Required]
            [MaxLength(100)]
            public string Name { get; set; } = null!;

            [MaxLength(150)]
            public string? CompanyName { get; set; }

            public bool IsVerified { get; set; }

        public profile orgProfile { get; set; } = null!;

        public List<Event> Events { get; set; } = new List<Event>();
    }


    }

