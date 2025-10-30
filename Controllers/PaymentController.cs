using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class PaymentController : BaseController<Product>
    {
        public PaymentController(IGenericRepository<Product> repository) : base(repository)
        {
        }
    }
}
