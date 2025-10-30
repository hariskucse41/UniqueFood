using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class RoleController : BaseController<Role>
    {
        public RoleController(IGenericRepository<Role> repository) : base(repository)
        {
        }
    }
}
