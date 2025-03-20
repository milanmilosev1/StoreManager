using SM.Domain.Models;

namespace SM.Application.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; } = [];
    }
}
