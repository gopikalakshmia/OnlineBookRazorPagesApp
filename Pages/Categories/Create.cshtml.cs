using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookRazorPagesApp.Data;
using OnlineBookRazorPagesApp.Model;

namespace OnlineBookRazorPagesApp.Pages.Categories{

    public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _db;
    [BindProperty]
    public Category category {get;set;}
    public CreateModel(ApplicationDbContext db)
    {
  
        _db=db;
    }

    public void OnGet()
    {
 
    }
    public IActionResult OnPost(){
     
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToPage("/Categories/Index");
       
    }
}
}




