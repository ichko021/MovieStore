using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models.Requests
{
    public class AddMovieRequest
    {
        public string Title { get; set; } = string.Empty;

        public int Year { get; set; }
    }
}
