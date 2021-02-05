
import websockets
import uuid
import json

from typing import Union, List


WEBSOCKET_URI = "wss://api.upbit.com/websocket/v1"


class UpbitWebSocket:

    def __init__(self, uri=None, ping_inverval=None, ping_timeout=None):
        self.__uri = uri if uri else WEBSOCKET_URI
        self.__conn = websockets.connect(
            uri=self.URI,
            ping_interval=ping_inverval,
            ping_timeout=ping_timeout
        )

    @property
    def URI(self):
        return self.__uri

    @URI.setter
    def URI(self, uri):
        self.__uri = uri

    @property
    def Connection(self):
        return self.__conn
    
    @Connection.setter
    def Connection(self, conn):
        self.__conn = conn

    @staticmethod
    def generate_orderbook_codes(
        currencies: Union[List[str]],
        counts: Union[List[int]] = None
    ) -> List[str]:
        codes = [
            f"{currency}.{count}"
            for currency, count
            in list(zip(currencies, counts))
        ] if counts else currencies
        return codes

    @staticmethod
    def generate_type_field(
        type: str,
        codes: Union[List[str]],
        isOnlySnapshot: bool = None,
        isOnlyRealtime: bool = None,
    ) -> dict:
        """
        :param type: 수신할 시세 타입 (현재가: `ticker`, 체결: `trade`, 호가: `orderbook`)
        :type type: str

        :param codes: 수신할 시세 종목 정보
        :type codes: list[str, ...]

        :param isOnlySnapshot: 시세 스냅샷만 제공 여부
        :type isOnlySnapshot: bool

        :param isOnlyRealtime: 실시간 시세만 제공 여부
        :type isOnlyRealtime: bool
        """
        field = {}

        if type in ['ticker', 'trade', 'orderbook']:
            field["type"] = type
        else:
            raise ValueError("'type' is not available")

        codes = [code.upper() for code in codes]
        field["codes"] = codes

        if isOnlySnapshot is not None:
            field["isOnlySnapshot"] = isOnlySnapshot
        if isOnlyRealtime is not None:
            field["isOnlyRealtime"] = isOnlyRealtime

        return field

    @staticmethod
    def generate_payload(
        type_fields: Union[List[dict]],
        ticket: str = None,
        format: str = 'DEFAULT'
    ) -> str:
        """
        :param type_fields: Type Fields
        :type type_fields: list[dict, ...]

        :param format: 포맷 (`SIMPLE`: 간소화된 필드명, `DEFAULT`: 기본값 (생략 가능))
        :type format: str

        :param ticket: 식별값
        :type ticket: str
        """
        payload = []

        ticket = ticket if ticket else str(uuid.uuid4())
        payload.append({"ticket": ticket})

        payload.extend(type_fields)

        fmt = format.upper()
        fmt = fmt if fmt in ['SIMPLE', 'DEFAULT'] else 'DEFAULT'
        payload.append({"format": fmt})

        return json.dumps(payload)

    async def __aenter__(self) -> websockets.client.WebSocketClientProtocol:
        return await self.Connection.__aenter__()

    async def __aexit__(self, exc_type, exc_value, traceback) -> None:
        await self.Connection.__aexit__(exc_type, exc_value, traceback)
