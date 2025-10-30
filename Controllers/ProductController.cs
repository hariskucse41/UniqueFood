using UniqueFood.API.Models;
using UniqueFood.API.Repositories;

namespace UniqueFood.API.Controllers
{
    public class ProductController : BaseController<Product>
    {
        public ProductController(IGenericRepository<Product> repository) : base(repository)
        {
        }
    }
}
