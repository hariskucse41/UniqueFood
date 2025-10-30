using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class PaymentController : BaseController<Payment>
    {
        public PaymentController(IGenericRepository<Payment> repository) : base(repository)
        {
        }
    }
}
