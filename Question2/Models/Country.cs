using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2.Models
{
    public class Country
    {
        public int Id { get; set; }
        public int CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }

        //public virtual ICollection<CountryDetails> CountryDetail { get; set; }
    }
}
