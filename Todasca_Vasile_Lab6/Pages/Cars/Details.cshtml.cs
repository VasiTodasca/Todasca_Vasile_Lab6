using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Todasca_Vasile_Lab6.Data;
using Todasca_Vasile_Lab6.Models;

namespace Todasca_Vasile_Lab6.Pages.Cars
{
    public class DetailsModel : PageModel
    {
        private readonly Todasca_Vasile_Lab6.Data.Todasca_Vasile_Lab6Context _context;

        public DetailsModel(Todasca_Vasile_Lab6.Data.Todasca_Vasile_Lab6Context context)
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
