using Lection0606.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApiServices;

namespace WebApp1.Pages
{
    public class DetailsModel(ReviewsApiService service) : PageModel
    {
        private readonly ReviewsApiService _service = service;

        [BindProperty]
        public Review Review { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Review = await _service.GetReviewAsync(id);

            if(Review is null) 
                return NotFound();  

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateReviewAsync(Review);
            return RedirectToPage("./Index");
        }
    }
}
