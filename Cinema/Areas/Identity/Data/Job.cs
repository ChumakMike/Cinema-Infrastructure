using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace Cinema.Areas.Identity.Data {
    public class Job {
        [Key]
        public int JobId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Obligations { get; set; }
    }
}
