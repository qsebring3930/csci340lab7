using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FavoriteCars.Data;
using FavoriteCars.Models;

namespace FavoriteCars.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly FavoriteCars.Data.FavoriteCarsContext _context;

        public IndexModel(FavoriteCars.Data.FavoriteCarsContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}
