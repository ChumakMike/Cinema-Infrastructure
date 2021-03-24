using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Identity.Data {
    public class Session {
        [Key]
        public int SessionId { get; set; }
        public DateTime ShowDate { get; set; }
        public int Price { get; set; }
    }
}
