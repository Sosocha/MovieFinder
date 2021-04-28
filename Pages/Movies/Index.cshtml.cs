using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieFinder.Data;
using MovieFinder.Model;

namespace MovieFinder.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieFinder.Data.MovieFinderContext _context;

        public IndexModel(MovieFinder.Data.MovieFinderContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
