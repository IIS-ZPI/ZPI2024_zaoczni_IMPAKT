from nbp_api_caller import NBPApiCaller
from datetime import datetime, timedelta
import common

caller = NBPApiCaller()


data_range = "1 year"

end_date = datetime.now()
start_date = end_date - timedelta(days=common.DATA_RANGES[data_range])

print(caller.fetch_exchange_rate("USD", "PLN", start_date, end_date))