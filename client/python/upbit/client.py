
from . import models
from seunggabi_core_python.util.config_util import Config


class Upbit:
    """
    Upbit Client
    Please read the official Upbit Client document.
    Documents: https://ujhin.github.io/upbit-client-docs/

    - Base URL: https://api.upbit.com
    - Base Path: /v1
    - Upbit OPEN API Version: 1.3.2
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
        profile: str = None,
        **kwargs
    ):
        if access_key is None and secret_key is None:
            credentials = Config.get(
                group="upbit",
                context="credentials",
                profile=profile
            )
            access_key = credentials["access_key"]
            secret_key = credentials["secret_key"]

        self.__client = models.ClientModel(
            access_key=access_key,
            secret_key=secret_key,
            **kwargs
        ).SWGClient

        self.__APIKey   = models.APIKey(self.__client)
        self.__Account  = models.Account(self.__client)
        self.__Candle   = models.Candle(self.__client)
        self.__Deposit  = models.Deposit(self.__client)
        self.__Market   = models.Market(self.__client)
        self.__Order    = models.Order(self.__client)
        self.__Trade    = models.Trade(self.__client)
        self.__Withdraw = models.Withdraw(self.__client)


    @property
    def APIKey(self):
        return self.__APIKey
    @property
    def Account(self):
        return self.__Account
    @property
    def Candle(self):
        return self.__Candle
    @property
    def Deposit(self):
        return self.__Deposit
    @property
    def Market(self):
        return self.__Market
    @property
    def Order(self):
        return self.__Order
    @property
    def Trade(self):
        return self.__Trade
    @property
    def Withdraw(self):
        return self.__Withdraw


    def __str__(self):
        return self.__repr__()

    def __repr__(self):
        return f"UpbitClient({models.HOST})"
