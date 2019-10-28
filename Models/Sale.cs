using System;
using System.Collections.Generic;

namespace reactmovie.api.Models
{
    public partial class Sale
    {
        public int SaleId { get; set; }
        public int? AuthorId { get; set; }
        public int? MovieId { get; set; }
        public DateTime SaleDate { get; set; }

        public virtual Author Author { get; set; }
        public virtual MovieTable Movie { get; set; }
    }
}
