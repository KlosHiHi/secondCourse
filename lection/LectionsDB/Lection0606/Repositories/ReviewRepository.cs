using Dapper;
using Lection0606.Database;
using Lection0606.Models;
using System.Data;

namespace Lection0606.Repositories
{
    public class ReviewRepository(IDataBaseFactory factory) : IReviewRepository
    {
        private readonly IDbConnection _db = factory.CreateConnection();

        public IEnumerable<Review> GetReviews()
            => _db.Query<Review>("SELECT * FROM Review");

        public Review GetReview(int id)
            => _db.QueryFirstOrDefault<Review>("SELECT * FROM Review WHERE Id=@id", new { id });

        public void UpdateReview(Review review)
            => _db.Execute("UPDATE Review SET Comment=@Comment Id=@Id", review);
    }
}
