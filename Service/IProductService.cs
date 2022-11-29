using WebApplication1.Entity;

namespace WebApplication1.Service
{
	public interface IProductService
	{
		Task<List<Product>> GetAll(CancellationToken cancellationToken);
	}
}
