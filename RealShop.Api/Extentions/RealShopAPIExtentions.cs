namespace RealShop.Api.Extentions;

public static class RealShopAPIExtentions
{
	public static IServiceCollection AddDbContext(this IServiceCollection service, IConfiguration configuration)
	{ 
		service.AddDbContextPool<ShopDbContext>(configuration.)

		return service;
	}
}
