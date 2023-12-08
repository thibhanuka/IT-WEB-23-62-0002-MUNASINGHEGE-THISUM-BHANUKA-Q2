using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentApp.Data;
using StudentApp.Model;

namespace StudentApp.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly StudentApp.Data.StudentAppContext _context;

        public CreateModel(StudentApp.Data.StudentAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseId");
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Student == null || Student == null)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();




            return RedirectToPage("./Index");
        }
    }
}
