using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Canducci.Pagination;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using Microsoft.AspNetCore.Mvc;
namespace appWeb.Pages
{
    public class CreatePeopleModel : PageModel
    {
        [BindProperty()]
        public People People {get; set;}
        public DatabaseContext Db { get; }
        public CreatePeopleModel(DatabaseContext db)
        {
            Db = db;
        }
        public void OnGet()
        {
             
        }

        public IActionResult OnPost()
        {
            if (People != null)
            {
                if (ModelState.IsValid)
                {
                    Db.People.Add(People);
                    Db.SaveChanges();
                }
            }
            return RedirectToPage("Peoples");
        }
    }
}