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
			var configuration = new ConfigurationOptions
			{
				EndPoints = { $"{_host}:{_port}" },
				AbortOnConnectFail = false,
			};

			_connectionMultiplexer = ConnectionMultiplexer.Connect(configuration);
		}
		public IDatabase GetDb(int db = 1) => _connectionMultiplexer.GetDatabase(0);
	}
}
