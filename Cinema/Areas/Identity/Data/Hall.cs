using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Identity.Data {
    public class Hall {
        [Key]
        public int HallId { get; set; }
        public string Name { get; set; }
    }
}
