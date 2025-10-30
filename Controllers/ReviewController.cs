using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class ReviewController : BaseController<Product>
    {
        public ReviewController(IGenericRepository<Product> repository) : base(repository)
        {
        }
    }
}

