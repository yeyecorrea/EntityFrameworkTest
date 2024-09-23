using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Views.Students
{
    public class CreateModel : PageModel
    {
        private readonly SchoolContext _context;

        public CreateModel(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Students Students { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Students);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
