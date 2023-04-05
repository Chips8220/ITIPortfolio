using System.Linq;

namespace SportsStores.Models
{
    public interface IProductRepository
    {
         IQueryable<Product> Products { get; }
    }
}
