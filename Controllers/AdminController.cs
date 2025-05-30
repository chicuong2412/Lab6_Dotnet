using Lab3_LeChiCuong_2131200001.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab3_LeChiCuong_2131200001.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        private readonly IWebHostEnvironment _env;

        public AdminController(AppDbContext context, IWebHostEnvironment env)
        {

            _context = context;
            _env = env;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserTable()
        {
            return View();
        }

        public async Task<IActionResult> BookManagement()
        {
            var books = await _context.Books
                  .Include(category => category.Categories)
                   .Include(author => author.Authors)
               .ToListAsync();
            return View(books);
        }
    }
}
