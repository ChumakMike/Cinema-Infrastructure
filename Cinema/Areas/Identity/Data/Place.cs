using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Identity.Data {
    public class Place {
        [Key]
        public int PlaceNumber { get; set; }
        public bool IsTaken { get; set; }
        [ForeignKey("HallId")]
        public int HallId { get; set; }
        public Hall Hall { get; set; }

        [ForeignKey("SessionId")]
        public int SessionId { get; set; }
        public Session Session { get; set; }

    }
}
