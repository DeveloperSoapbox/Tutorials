using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeerApp.Data;
using BeerApp.Models;

namespace BeerApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BeerApp.Data.BeerContext _context;

        public IndexModel(BeerApp.Data.BeerContext context)
        {
            _context = context;
        }

        public IList<Beer> Beer { get;set; }

        public async Task OnGetAsync()
        {
            Beer = await _context.Beers.ToListAsync();
        }
    }
}
