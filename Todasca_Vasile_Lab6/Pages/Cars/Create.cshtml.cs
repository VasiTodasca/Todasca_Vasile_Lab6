using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Todasca_Vasile_Lab6.Data;
using Todasca_Vasile_Lab6.Models;

namespace Todasca_Vasile_Lab6.Pages.Cars
{
    public class CreateModel : PageModel
    {
        private readonly Todasca_Vasile_Lab6.Data.Todasca_Vasile_Lab6Context _context;

        public CreateModel(Todasca_Vasile_Lab6.Data.Todasca_Vasile_Lab6Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Car Car { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Car.Add(Car);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
