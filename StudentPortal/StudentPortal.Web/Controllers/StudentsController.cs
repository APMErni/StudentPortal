using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Data;
using StudentPortal.Web.Models;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Program = viewModel.Program
            };

            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "Students");
            //return View();
        }

        // Read: view list of records in the database
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();

            return View(students);
        }

        // Update: edit existing records 
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student = await dbContext.Students.FindAsync(viewModel.Id);

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            if (student is not null)
            {
                student.Name = viewModel.Name;
                student.Email = viewModel.Email;
                student.Phone = viewModel.Phone;
                student.Program = viewModel.Program;

                await dbContext.SaveChangesAsync();
            }
            // pass it back to the list and the controller is Students
            return RedirectToAction("List", "Students");
        }

        // Delete
        
        public async Task<IActionResult> Delete(Student viewModel)
        {
            var student = await dbContext.Students.AsNoTracking().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

            if (student is not null)
            {
                dbContext.Students.Remove(viewModel);
                await dbContext.SaveChangesAsync();
                //return View(student);
                return RedirectToAction("List", "Students");
            }

            //return View(student);
            return RedirectToAction("List", "Students");
        }

    }
}
