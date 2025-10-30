using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class RoleController : BaseController<Product>
    {
        public RoleController(IGenericRepository<Product> repository) : base(repository)
        {
        }
    }
}
