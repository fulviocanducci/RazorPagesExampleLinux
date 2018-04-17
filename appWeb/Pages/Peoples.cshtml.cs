using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Canducci.Pagination;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;

namespace appWeb.Pages
{
    public class PeoplesModel : PageModel
    {
        public Paginated<People> Items {get; private set;}
        public DatabaseContext Db { get; }

        public PeoplesModel(DatabaseContext db)
        {
            Db = db;
        }
        public void OnGet(int? current)
        {
             Items = Db.People
                .OrderBy(x => x.Name)
                .ToPaginated(current ?? 1, 4);
        }
    }
}