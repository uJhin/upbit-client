
from upbit.models import *


class Upbit:
    """
    Upbit Client
    Please read the official Upbit Client document.
    Documents: https://ujhin.github.io/upbit-client-docs/

    - Base URL: https://api.upbit.com
    - Base Path: /v1
    - Upbit OPEN API Version: 1.1.6
    - Author: ujhin
    - Email: ujhin942@gmail.com
    - GitHub: https://github.com/uJhin
    - Official OPEN API Documents: https://docs.upbit.com
    - Official Support Email: open-api@upbit.com
    """

    def __init__(self, access_key: str = None, secret_key: str = None, **kwargs):
        self.__client = ClientModel(access_key=access_key, secret_key=secret_key, **kwargs).UpbitClient
        self.APIKey = APIKey(self.__client)
        self.Account = Account(self.__client)
        self.Candle = Candle(self.__client)
        self.Deposit = Deposit(self.__client)
        self.Market = Market(self.__client)
        self.Order = Order(self.__client)
        self.Trade = Trade(self.__client)
        self.Withdraw = Withdraw(self.__client)

    def __str__(self):
        return f"UpbitClient({HOST})"

    def __repr__(self):
        return f"UpbitClient({HOST})"
