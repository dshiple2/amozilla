using System;
using System.Linq;
using amozilla.Models;
using Microsoft.AspNetCore.Mvc;

namespace amozilla.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IBookRepository repo { get; set; }
        public TypesViewComponent (IBookRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["bookGenre"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }

    }
}
