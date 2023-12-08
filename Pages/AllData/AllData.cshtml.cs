
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentApp.Data;
using StudentApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentApp.Pages.AllData
{
    public class AllDataModel : PageModel
    {
        private readonly StudentAppContext _context;

        public AllDataModel(StudentAppContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get; set; }
        public IList<Student> Students { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Course.ToListAsync();
            Students = await _context.Student.ToListAsync();
        }
    }
}

