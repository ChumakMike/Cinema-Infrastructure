using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Identity.Data {
    public class Film {
        [Key]
        public int FilmId { get; set; }
        public string Name { get; set; }
        [ForeignKey("GenreId")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int Duration { get; set; }
        public string Creator { get; set; }
        public string Description { get; set; }
        public string Actors { get; set; }
    }
}
