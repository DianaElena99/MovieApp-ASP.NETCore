using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myWebApp.Models;

namespace myWebApp.Pages.NewFolder
{
    public class IndexModel : PageModel
    {
        private readonly myWebApp.Models.MovieAppDBContext _context;

        public IndexModel(myWebApp.Models.MovieAppDBContext context)
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
