using Dapper;
using Lection0606.Database;
using Lection0606.Models;
using System.Data;

namespace Lection0606.Repositories
{
    public interface IRepository<T> where T : class
    {


        IEnumerable<T> GetAll();
        T? GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }

    public class ReviewsRepository(IDataBaseFactory factory) : IRepository<Review>
    {
        private readonly IDbConnection _factory = factory.CreateConnection();

        public IEnumerable<Review> GetAll()
            => _factory.Query<Review>("SELECT * FROM Review");

        public Review? GetById(int id)
            => _factory.QueryFirstOrDefault<Review>("SELECT * FROM Review WHERE Id=@id", new { id });

        public void Create(Review entity)
            => throw new NotImplementedException();

        public void Update(Review entity)
            => _factory.Execute("UPDATE Review SET Comment=@Comment, [User]=@User WHERE Id=@Id", entity);

        public void Delete(int id)
            => _factory.Execute("DELETE Review WHERE Id=@id", new { id });
    }
}
