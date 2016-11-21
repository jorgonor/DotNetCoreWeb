using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class TodoController : Controller
    {  
        protected readonly ApplicationDbContext _context;

        public TodoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Todos.ToListAsync());
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("Title, Comments, DueDate")] Todo todo)
        {
            if (ModelState.IsValid) {
                _context.Todos.Add(todo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(todo);
        }
    }
}