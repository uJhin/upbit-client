
from . import models


class Upbit:
    """
    Upbit Client
    Please read the official Upbit Client document.
    Documents: https://ujhin.github.io/upbit-client-docs/

    - Base URL: https://api.upbit.com
    - Base Path: /v1
    - Upbit OPEN API Version: 1.1.7
    - Author: ujhin
    - Email: ujhin942@gmail.com
    - GitHub: https://github.com/uJhin
    - Official OPEN API Documents: https://docs.upbit.com
    - Official Support Email: open-api@upbit.com
    """

    def __init__(
        self,
        access_key: str = None,
        secret_key: str = None,
        **kwargs
    ):

        self.__client = models.ClientModel(
            access_key=access_key,
            secret_key=secret_key,
            **kwargs
        ).SWGClient

        self.APIKey = models.APIKey(self.__client)
        self.Account = models.Account(self.__client)
        self.Candle = models.Candle(self.__client)
        self.Deposit = models.Deposit(self.__client)
        self.Market = models.Market(self.__client)
        self.Order = models.Order(self.__client)
        self.Trade = models.Trade(self.__client)
        self.Withdraw = models.Withdraw(self.__client)

    def __str__(self):
        return self.__repr__()

    def __repr__(self):
        return f"UpbitClient({models.HOST})"
