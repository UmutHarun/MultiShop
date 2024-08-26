using StackExchange.Redis;

namespace MultiShop.Basket.Settings
{
	public class RedisService
	{
		public string _host { get; set; }
		public int _port { get; set; }

		private ConnectionMultiplexer _connectionMultiplexer;
		public RedisService(string host, int port)
		{
			_host = host;
			_port = port;
		}

		public void Connect()
		{
			try
			{
				var configuration = new ConfigurationOptions
				{
					EndPoints = { $"{_host}:{_port}" },
				};

				_connectionMultiplexer = ConnectionMultiplexer.Connect(configuration);
			}
			catch (Exception ex)
			{
				// Hata mesajını logla
				Console.WriteLine($"Redis'e bağlanırken hata oluştu: {ex.Message}");
				throw;
			}
		}
		public IDatabase GetDb(int db = 1) => _connectionMultiplexer.GetDatabase(0);
	}
}
