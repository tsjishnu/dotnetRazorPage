using Ambicion.Data;
using Ambicion.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ambicion.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Category = _db.Categories.Find(id);
        }
        public async Task<IActionResult> OnPost(Category category)
        {
                var categoryFromDb = _db.Categories.Find(category.Id);
                if (categoryFromDb != null)
                {
                    _db.Categories.Remove(categoryFromDb);
                    await _db.SaveChangesAsync();
                    TempData["Success"] = "Category Deleted Succefully";
                    return RedirectToPage("Index");
                }
            return Page();
        }
    }
}
