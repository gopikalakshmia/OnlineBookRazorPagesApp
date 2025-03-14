using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookRazorPagesApp.Data;
using OnlineBookRazorPagesApp.Model;

namespace OnlineBookRazorPagesApp.Pages.Categories{

    public class EditModel : PageModel
{
    private readonly ApplicationDbContext _db;
    [BindProperty]
    public Category category {get;set;}
    public EditModel(ApplicationDbContext db)
    {
  
        _db=db;
    }

    public void OnGet(int? id)
    {
        category=_db.Categories.Find(id);
    }
    public IActionResult OnPost(){
     
            _db.Categories.Update(category);
            _db.SaveChanges();
            return RedirectToPage("/Categories/Index");
       
    }
}
}




