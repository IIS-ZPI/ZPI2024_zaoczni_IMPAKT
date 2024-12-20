from nbp_api_caller import NBPApiCaller

caller = NBPApiCaller()

print(caller.fetch_exchange_rate("USD", "PLN", "1 year"))