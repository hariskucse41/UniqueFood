using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class UserController : BaseController<User>
    {
        public UserController(IGenericRepository<User> repository) : base(repository)
        {
        }
    }
}
