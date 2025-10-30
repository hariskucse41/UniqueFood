using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class UserController : BaseController<Product>
    {
        public UserController(IGenericRepository<Product> repository) : base(repository)
        {
        }
    }
}
