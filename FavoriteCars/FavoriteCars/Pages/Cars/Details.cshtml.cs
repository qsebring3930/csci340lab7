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
    public class DetailsModel : PageModel
    {
        private readonly FavoriteCars.Data.FavoriteCarsContext _context;

        public DetailsModel(FavoriteCars.Data.FavoriteCarsContext context)
        {
            _context = context;
        }

        public Car Car { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Car = await _context.Car.FirstOrDefaultAsync(m => m.ID == id);

            if (Car == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
