using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class CartController : BaseController<Product>
    {
        public CartController(IGenericRepository<Product> repository) : base(repository)
        {
        }
    }
}
