using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class OrderController : BaseController<Product>
    {
        public OrderController(IGenericRepository<Product> repository) : base(repository)
        {
        }
    }
}
