using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using amozilla.Models;
using amozilla.Models.ViewModels;

namespace amozilla.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository repo;

        public HomeController(IBookRepository temp)
        {
            repo = temp;
        }


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        

        public IActionResult Index(string bookGenre, int pageNum = 1)
        {

            int pageSize = 10;
            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(b => b.Category == bookGenre || bookGenre == null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),




                PageInfo = new PageInfo
                {
                    TotalNumBooks = (bookGenre == null ? repo.Books.Count() : repo.Books.Where(x => x.Category == bookGenre).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }

            };

         
            return View(x);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
