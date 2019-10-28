using System;
using System.Collections.Generic;

namespace reactmovie.api.Models
{
    public partial class MovieTable
    {
        public MovieTable()
        {
            Author = new HashSet<Author>();
            Sale = new HashSet<Sale>();
        }

        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public int? Stock { get; set; }
        public string Language { get; set; }

        public virtual ICollection<Author> Author { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
