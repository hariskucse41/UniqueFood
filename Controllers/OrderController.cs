using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class OrderController : BaseController<Order>
    {
        public OrderController(IGenericRepository<Order> repository) : base(repository)
        {
        }
    }
}
