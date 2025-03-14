using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookRazorPagesApp.Data;
using OnlineBookRazorPagesApp.Model;

namespace OnlineBookRazorPagesApp.Pages.Categories{

    public class IndexModel : PageModel
{
    //private readonly ILogger<PrivacyModel> _logger;
    private readonly ApplicationDbContext _db;
    public List<Category> categorieslist {get;set;}
    public IndexModel(ApplicationDbContext db)
    {
  
        _db=db;
    }

    public void OnGet()
    {
        categorieslist=_db.Categories.ToList();
    }
}
}




