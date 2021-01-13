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
    public class IndexModel : PageModel
    {
        private readonly Todasca_Vasile_Lab6.Data.Todasca_Vasile_Lab6Context _context;

        public IndexModel(Todasca_Vasile_Lab6.Data.Todasca_Vasile_Lab6Context context)
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
