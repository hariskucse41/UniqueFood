using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class ReviewController : BaseController<Review>
    {
        public ReviewController(IGenericRepository<Review> repository) : base(repository)
        {
        }
    }
}

