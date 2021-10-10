using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Makes { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CarMakes { get; set; }

        public async Task OnGetAsync()
        {
            var cars = from c in _context.Car
                         select c;
            if (!string.IsNullOrEmpty(SearchString))
            {
                cars = cars.Where(s => s.Model.Contains(SearchString));
            }

            Car = await cars.ToListAsync();
        }
    }
}
