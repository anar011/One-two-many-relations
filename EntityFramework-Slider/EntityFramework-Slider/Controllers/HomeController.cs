using EntityFramework_Slider.Data;
using EntityFramework_Slider.Models;
using EntityFramework_Slider.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntityFramework_Slider.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();

            SliderInfo sliderInfo = await _context.SliderInfos.FirstOrDefaultAsync();

            IEnumerable<Blog> blogs = await _context.Blogs.Where(m=>!m.SoftDelete).ToListAsync();

            IEnumerable<Category> categories = await _context.Categories.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<Product> products = await _context.Products.Include(m=>m.Images).Where(m => !m.SoftDelete).ToListAsync();

            About about = await _context.Abouts.Include(a=>a.AboutDescs).Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            IEnumerable<AboutDesc> aboutdescs = await _context.AboutDescs.Where(m => !m.SoftDelete).ToListAsync();

            Expert expert = await _context.Experts.Include(a => a.ExpertImages).Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            IEnumerable<ExpertImage> expertImages = await _context.ExpertImages.Where(m => !m.SoftDelete).ToListAsync();






            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo,
                Blogs = blogs,
                Categories = categories,
                Products = products,
                Abouts = about,
                Experts = expert
             
            };

            return View(model);
        }
    }
}