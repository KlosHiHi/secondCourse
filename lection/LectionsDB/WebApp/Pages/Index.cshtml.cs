using Lection0606.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApiServices;

namespace WebApp1.Pages
{
    public class IndexModel(ReviewsApiService service) : PageModel
    {
        private readonly ReviewsApiService _service = service;

        public IEnumerable<Review> Reviews { get; set; }

        public async Task OnGetAsync()
        {
            Reviews = await _service.GetReviewsAsync();
        }
    }
}
