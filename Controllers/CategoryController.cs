using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class CategoryController : BaseController<Category>
    {
        public CategoryController(IGenericRepository<Category> repository) : base(repository)
        {
        }
    }
}
