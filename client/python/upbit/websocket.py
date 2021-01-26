import websockets
import uuid
import json

from typing import Union, List


WEBSOCKET_HOST = "wss://api.upbit.com/websocket/v1"


class UpbitWebSocket:

    def __init__(self):
        self.host = WEBSOCKET_HOST

    async def request(self, payload: str) -> dict:
        async with websockets.connect(self.host) as conn:
            await conn.send(payload)
            data = await conn.recv()
        return json.loads(data.decode('utf-8'))

    @staticmethod
    def generate_orderbook_codes(currencies: Union[List[str]], counts: Union[List[int]] = None):
        codes = [
            f"{currency}.{count}"
            for currency, count
            in list(zip(currencies, counts))
        ] if counts else currencies
        return codes

    @staticmethod
    def generate_payload(type: str, codes: Union[List[str]], isOnlySnapshot: bool = None, isOnlyRealtime: bool = None, format: str = 'DEFAULT', ticket: str = None) -> str:
        """
        :param type: 수신할 시세 타입 (현재가: ticker, 체결: trade, 호가: orderbook)
        :type type: str

        :param codes: 수신할 시세 종목 정보
        :type codes: list[str,]

        :param isOnlySnapshot: 시세 스냅샷만 제공 여부
        :type isOnlySnapshot: bool

        :param isOnlyRealtime: 실시간 시세만 제공 여부
        :type isOnlyRealtime: bool

        :param format: 포맷 (SIMPLE: 간소화된 필드명, DEFAULT (생략 가능))
        :type format: str

        :param ticket: 식별값
        :type ticket: str
        """
        payload = []

        ticket = ticket if ticket else str(uuid.uuid4())
        payload.append({"ticket": ticket})

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
        payload.append(field)

        format = format.upper() if format.upper() in ['SIMPLE', 'DEFAULT'] else 'DEFAULT'
        payload.append({"format": format})

        return json.dumps(payload)
