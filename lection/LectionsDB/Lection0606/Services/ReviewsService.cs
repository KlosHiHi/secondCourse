using Lection0606.Models;
using Lection0606.Repositories;

namespace Lection0606.Services
{
    public class ReviewsService(ReviewsRepository repository)
    {
        private readonly ReviewsRepository _repository = repository;

        public IEnumerable<Review> GetAll()
        {
            Console.WriteLine("начало получения данных");

            var reviews = _repository.GetAll();

            Console.WriteLine("конец получения данных");

            return reviews;
        }

        public Review GetById(int id)
        {
            var review = _repository.GetById(id);
            if (review is null)
                throw new KeyNotFoundException();
           
            return review;
        }

        public IEnumerable<Review> GetAllByGameId(int id)
        {
            var reviews = _repository.GetAll()
                .Where(r => r.GameId == id);
            return reviews;
        }
    }
}
