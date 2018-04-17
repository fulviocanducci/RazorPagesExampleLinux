using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Microsoft.AspNetCore.Mvc;
namespace appWeb.Pages
{
    public class EditPeopleModel : PageModel
    {
        [BindProperty()]
        public People People {get; set;}
        public DatabaseContext Db { get; }
        public EditPeopleModel(DatabaseContext db)
        {
            Db = db;
        }
        public IActionResult OnGet(int id)
        {
            if (id > 0)
            {
                People = Db.People.Find(id);
            }
            if (People == null)
            {
                return RedirectToPage("Peoples");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (People != null)
            {
                if (ModelState.IsValid)
                {
                    Db.People.Update(People);
                    Db.SaveChanges();
                }
            }
            return RedirectToPage("Peoples");
        }
    }
}