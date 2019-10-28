using System;
using System.Collections.Generic;

namespace reactmovie.api.Models
{
    public partial class Author
    {
        public Author()
        {
            Sale = new HashSet<Sale>();
        }

        public int AuthorId { get; set; }
        public string Author1 { get; set; }
        public string Place { get; set; }
        public int? MovieId { get; set; }

        public virtual MovieTable Movie { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
