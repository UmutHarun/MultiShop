using MultiShop.Basket.Dtos;
using MultiShop.Basket.Settings;
using System.Text.Json;

namespace MultiShop.Basket.Services
{
	public class BasketService : IBasketService
	{
		private readonly RedisService _redisService;

		public BasketService(RedisService redisService)
		{
			_redisService = redisService;
		}

		public async Task DeleteBasket(string userId)
		{
			await _redisService.GetDb().KeyDeleteAsync(userId);
		}

		public async Task<BasketTotalDto> GetBasket(string userId)
		{
			var existBasket = await _redisService.GetDb().StringGetAsync(userId);
			return JsonSerializer.Deserialize<BasketTotalDto>(existBasket);
			//if(String.IsNullOrEmpty(existBasket))
		}

		public async Task SaveBasket(BasketTotalDto basket)
		{
			string serializedBasket = JsonSerializer.Serialize(basket);
			var db = _redisService.GetDb();
			await db.StringSetAsync(basket.UserId, serializedBasket);
		}
	}
}
