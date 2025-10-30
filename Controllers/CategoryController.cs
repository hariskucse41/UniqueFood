using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class CategoryController : BaseController<Product>
    {
        public CategoryController(IGenericRepository<Product> repository) : base(repository)
        {
        }
    }
}
