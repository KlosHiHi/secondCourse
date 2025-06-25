using Lection0606.Models;

namespace Lection0606.Repositories
{
    public interface IReviewRepository
    {
        Review GetReview(int id);
        IEnumerable<Review> GetReviews();
        void UpdateReview(Review review);
    }
}
