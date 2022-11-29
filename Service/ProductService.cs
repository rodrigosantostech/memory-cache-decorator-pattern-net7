using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using WebApplication1.Context;
using WebApplication1.Entity;

namespace WebApplication1.Service
{
	public class ProductService : IProductService
	{
		private readonly DataContext _context;
		private readonly IMemoryCache _memoryCache;

		public ProductService(DataContext context, IMemoryCache memoryCache)
		{
			_context = context;
			_memoryCache = memoryCache;
		}

		public async Task<List<Product>> GetAll(CancellationToken cancellationToken)
		{
			return await _context.Products
				.OrderBy(x => x.Name)
				.ToListAsync(cancellationToken);
		}
	}
}
