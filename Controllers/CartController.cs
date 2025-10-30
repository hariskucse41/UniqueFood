using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class CartController : BaseController<Cart>
    {
        public CartController(IGenericRepository<Cart> repository) : base(repository)
        {
        }
    }
}
