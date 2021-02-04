
from bravado.requests_client import RequestsClient as rc
from bravado.client import SwaggerClient as sc

from upbit.authentication import APIKeyAuthenticator
from upbit.utils import HTTPFutureExtractor


HOST = "https://api.upbit.com"
SPEC_URI = "https://raw.githubusercontent.com/uJhin/upbit-client/main/mapper/swg_mapper.json"


class ClientModel:

    def __init__(self, access_key: str = None, secret_key: str = None, **kwargs):
        arg_config = kwargs.get('config')
        arg_spec_uri = kwargs.get('spec_uri')
        config = {
            'also_return_response': False,
            'validate_responses': False,
            'use_models': False,
            'host': HOST
        } if not arg_config else arg_config
        spec_uri = SPEC_URI if not arg_spec_uri else arg_spec_uri

        if access_key and secret_key:

            request_client = rc()
            request_client.authenticator = APIKeyAuthenticator(
                config['host'], access_key, secret_key)

            self.__client = sc.from_url(
                spec_url=spec_uri, http_client=request_client, config=config)

        else:

            self.__client = sc.from_url(spec_url=spec_uri, config=config)

    @property
    def UpbitClient(self):
        return self.__client


class APIKey:
    """
    API Key
    """

    def __init__(self, client):
        self.__client = client

    def APIKey_info(self) -> dict:
        """
        [GET] API 키 리스트 조회
        
        ## API 키 목록 및 만료 일자를 조회합니다.
        """
        future = self.__client.APIKey.APIKey_info()
        return HTTPFutureExtractor.future_extraction(future)


class Account:
    """
    계좌
    """

    def __init__(self, client):
        self.__client = client

    def Account_info(self) -> dict:
        """
        [GET] 전체 계좌 조회
        
        ## 내가 보유한 자산 리스트를 보여줍니다.
        """
        future = self.__client.Account.Account_info()
        return HTTPFutureExtractor.future_extraction(future)

    def Account_wallet(self) -> dict:
        """
        [GET] 입출금 현황

        ## 입출금 현황 및 블록 상태를 조회합니다.

        [NOTE] 입출금 현황 데이터는 실제 서비스 상태와 다를 수 있습니다.
        
        입출금 현황 API에서 제공하는 입출금 상태, 블록 상태 정보는 수 분 정도 지연되어 반영될 수 있습니다.
        본 API는 참고용으로만 사용하시길 바라며 실제 입출금을 수행하기 전에는 반드시 업비트 공지사항 및 입출금 현황 페이지를 참고해주시기 바랍니다.
        """
        future = self.__client.Account.Account_wallet()
        return HTTPFutureExtractor.future_extraction(future)


class Candle:
    """
    캔들; 봉
    """

    def __init__(self, client):
        self.__client = client

    def Candle_minutes(self, **kwargs) -> dict:
        """
        [GET] 시세 캔들 조회 (분 단위)

        ## 분(Minute) 캔들

        :param unit: 분 단위.
        가능한 값: 1, 3, 5, 15, 10, 30, 60, 240
        :type unit: int

        :param market: 마켓 코드 (ex. KRW-BTC)
        :type market: str

        :param to: 마지막 캔들 시각 (exclusive).
        포맷: `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`.
        비워서 요청 시 가장 최근 캔들 (optional)
        :type to: str

        :param count: 캔들 개수 (최대 200개까지 요청 가능) (optional)
        :type count: number
        """
        future = self.__client.Candle.Candle_minutes(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Candle_days(self, **kwargs) -> dict:
        """
        [GET] 시세 캔들 조회 (일 단위)

        ## 일(Day) 캔들

        :param market: 마켓 코드 (ex. KRW-BTC)
        :type market: str

        :param to: 마지막 캔들 시각 (exclusive).
        포맷: `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`.
        비워서 요청 시 가장 최근 캔들 (optional)
        :type to: str

        :param count: 캔들 개수 (optional)
        :type count: number

        :param convertingPriceUnit: 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)
        `convertingPriceUnit` 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시
        종가를 명시된 파라미터 값으로 환산해 `converted_trade_price` 필드에 추가하여 반환합니다.
        현재는 원화(`KRW`) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다. (Default: KRW) (optional)
        :type convertingPriceUnit: str
        """
        future = self.__client.Candle.Candle_days(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Candle_weeks(self, **kwargs) -> dict:
        """
        [GET] 시세 캔들 조회 (주 단위)

        ## 주(Week) 캔들

        :param market: 마켓 코드 (ex. KRW-BTC)
        :type market: str

        :param to: 마지막 캔들 시각 (exclusive).
        포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`.
        비워서 요청 시 가장 최근 캔들 (optional)
        :type to: str

        :param count: 캔들 개수 (optional)
        :type count: number
        """
        future = self.__client.Candle.Candle_weeks(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Candle_month(self, **kwargs) -> dict:
        """
        [GET] 시세 캔들 조회 (월 단위)

        ## 월(Month) 캔들

        :param market: 마켓 코드 (ex. KRW-BTC)
        :type market: str

        :param to: 마지막 캔들 시각 (exclusive).
        포맷: `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`.
        비워서 요청 시 가장 최근 캔들 (optional)
        :type to: str
        
        :param count: 캔들 개수 (optional)
        :type count: number
        """
        future = self.__client.Candle.Candle_month(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)


class Deposit:
    """
    입금
    """

    def __init__(self, client):
        self.__client = client

    def Deposit_coin_address(self, **kwargs) -> dict:
        """
        [GET] 개별 입금 주소 조회

        ## 개별 입금 주소 조회

        [NOTE] 입금 주소 조회 요청 API 유의사항

        입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다.

        :param currency: Currency symbol
        :type currency: str
        """
        future = self.__client.Deposit.Deposit_coin_address(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Deposit_coin_addresses(self) -> dict:
        """
        [GET] 전체 입금 주소 조회

        ## 내가 보유한 자산 리스트를 보여줍니다.
        [NOTE] 입금 주소 조회 요청 API 유의사항

        입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다.
        """
        future = self.__client.Deposit.Deposit_coin_addresses()
        return HTTPFutureExtractor.future_extraction(future)

    def Deposit_generate_coin_address(self, **kwargs) -> dict:
        """
        [POST] 입금 주소 생성 요청

        입금 주소 생성을 요청한다.

        [NOTE] 입금 주소 생성 요청 API 유의사항
        
        입금 주소의 생성은 서버에서 비동기적으로 이뤄집니다.
        비동기적 생성 특성상 요청과 동시에 입금 주소가 발급되지 않을 수 있습니다.
        주소 발급 요청 시 결과로 Response1이 반환되며 주소 발급 완료 이전까지 계속 Response1이 반환됩니다.
        주소가 발급된 이후부터는 새로운 주소가 발급되는 것이 아닌 이전에 발급된 주소가 Response2 형태로 반환됩니다.
        정상적으로 주소가 생성되지 않는다면 일정 시간 이후 해당 API를 다시 호출해주시길 부탁드립니다.


        :param currency: Currency 코드
        :type currency: string
        """
        future = self.__client.Deposit.Deposit_generate_coin_address(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Deposit_info(self, **kwargs) -> dict:
        """
        [GET] 개별 입금 조회

        ## 개별 입금 조회

        :param uuid: 입금 UUID (optional)
        :type uuid: string

        :param txid: 입금 TXID (optional)
        :type txid: string

        :param currency: Currency 코드 (optional)
        :type currency: string
        """
        future = self.__client.Deposit.Deposit_info(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Deposit_info_all(self, **kwargs) -> dict:
        """
        [GET] 입금 리스트 조회

        ## 입금 리스트 조회

        :param currency: Currency 코드 (optional)
        :type currency: str

        :param state: 출금 상태 (optional)
        - submitting : 처리 중
        - submitted : 처리완료
        - almost_accepted : 입금 대기 중
        - rejected : 거절
        - accepted : 승인됨
        - processing : 처리 중
        :type state: str

        :param uuids: 입금 UUID의 목록 (optional)
        :type uuids: list

        :param txids: 입금 TXID의 목록 (optional)
        :type txids: list

        :param limit: 개수 제한 (default: 100, max: 100) (optional)
        :type limit: number

        :param page: 페이지 수, default: 1 (optional)
        :type page: number

        :param order_by: 정렬 방식 (optional)
        - asc : 오름차순
        - desc : 내림차순 (default)
        :type order_by: str
        """
        future = self.__client.Deposit.Deposit_info_all(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)


class Market:
    """
    마켓(시장)
    """

    def __init__(self, client):
        self.__client = client
    
    def Market_info_all(self, **kwargs) -> dict:
        """
        [GET] 마켓 코드 조회
        
        ## 업비트에서 거래 가능한 마켓 목록

        :param isDetails: 유의종목 필드과 같은 상세 정보 노출 여부(선택 파라미터)(Default: False) (optional)
        :type isDetails: bool
        """
        future = self.__client.Market.Market_info_all(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)


class Order:
    """
    주문
    """

    def __init__(self, client):
        self.__client = client

    def Order_orderbook(self, **kwargs) -> dict:
        """
        [GET] 시세 호가 정보(Orderbook) 조회

        ## 호가 정보 조회

        :param markets: 마켓 코드 목록 (ex. [KRW-BTC, KRW-ADA])
        """
        future = self.__client.Order.Order_orderbook(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Order_chance(self, **kwargs) -> dict:
        """
        [GET] 주문 가능 정보

        ## 마켓별 주문 가능 정보를 확인한다.

        :param market: Market ID
        """
        future = self.__client.Order.Order_chance(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)
    
    def Order_info(self, **kwargs):
        """
        [GET] 개별 주문 조회

        ## 주문 UUID를 통해 개별 주문건을 조회한다.

        [NOTE] `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다.

        :param uuid: 주문 UUID (optional)
        :type uuid: str

        :param identifier: 조회용 사용자 지정 값 (optional)
        :type identifier: str
        """
        future = self.__client.Order.Order_info(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)
    
    def Order_info_all(self, **kwargs) -> dict:
        """
        [GET] 주문 리스트 조회

        ## 주문 리스트를 조회한다.

        :param market: 마켓 아이디 (optional)
        :type market: str

        :param state: 주문 상태 (optional)
        - wait : 체결 대기 (default)
        - done : 전체 체결 완료
        - cancel : 주문 취소
        :type state: str

        :param states: 주문 상태의 목록 (optional)
        :type states: list

        :param uuids: 주문 UUID의 목록 (optional)
        :type uuids: list

        :param identifiers: 주문 identifier의 목록 (optional)
        :type identifiers: array

        :param page: 페이지 수, default: 1 (optional)
        :type page: number

        :param limit: 요청 개수, default: 100 (optional)
        :type limit: number

        :param order_by: 정렬 방식 (optional)
        - asc : 오름차순
        - desc : 내림차순 (default)
        :type order_by: str
        """
        future = self.__client.Order.Order_info_all(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)
    
    def Order_new(self, **kwargs) -> dict:
        """
        [POST] 주문하기

        ## 주문 요청을 한다.
        [NOTE] 원화 마켓 가격 단위를 확인하세요.
        
        원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요.

        [NOTE] identifier 파라미터 사용
        
        `identifier`는 서비스에서 발급하는 `uuid`가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다.
        해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다.
        주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 `identifier` 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요.

        [NOTE] 시장가 주문

        시장가 주문은 `ord_type` 필드를 `price` or `market` 으로 설정해야됩니다.
        매수 주문의 경우 `ord_type`을 `price`로 설정하고 `volume`을 `null` 혹은 제외해야됩니다.
        매도 주문의 경우 `ord_type`을 `market`로 설정하고 `price`을 `null` 혹은 제외해야됩니다.


        :param market: 마켓 ID (필수)
        :type market: str

        :param side: 주문 종류 (필수)
        - bid : 매수
        - ask : 매도
        :type side: str

        :param volume: 주문량 (지정가, 시장가 매도 시 필수) (Default: null) (optional)
        :type volume: str

        :param price: 주문 가격. (지정가, 시장가 매수 시 필수)
        ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다.
        ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음) (Default: null) (optional)
        :type price: str

        :param ord_type: 주문 타입 (필수)
        - limit : 지정가 주문
        - price : 시장가 주문(매수)
        - market : 시장가 주문(매도)
        :type ord_type: str

        :param identifier: 조회용 사용자 지정값 (선택) (optional)
        :type identifier: str
        """
        future = self.__client.Order.Order_new(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)
    
    def Order_cancel(self, **kwargs) -> dict:
        """
        [DELETE] 주문 취소 접수

        ## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다.

        [NOTE] `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다.
        
        :param uuid: 취소할 주문의 UUID (optional)
        :type uuid: string

        :param identifier: 조회용 사용자 지정 값 (optional)
        :type identifier: string
        """
        future = self.__client.Order.Order_cancel(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)


class Trade:
    """
    거래
    """

    def __init__(self, client):
        self.__client = client

    def Trade_ticker(self, **kwargs) -> dict:
        """
        [GET] 시세 Ticker 조회

        ## 현재가 정보

        요청 당시 종목의 스냅샷을 반환한다.

        :param markets: 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC)
        :type markets: str
        """
        future = self.__client.Trade.Trade_ticker(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Trade_ticks(self, **kwargs) -> dict:
        """
        [GET] 시세 체결 조회

        ## 최근 체결 내역

        :param market: 마켓 코드 (ex. KRW-BTC, BTC-BCC)
        :type market: str

        :param to: 마지막 체결 시각.
        형식: `[HHmmss 또는 HH:mm:ss]`.
        비워서 요청시 가장 최근 데이터 (optional)
        :type to: str

        :param count: 체결 개수 (optional)
        :type count: number

        :param cursor: 페이지네이션 커서 (sequentialId)
        `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다.
        하지만 체결의 순서를 보장하지는 못합니다. (optional)
        :type cursor: str

        :param daysAgo: 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능.
        비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7) (optional)
        :type daysAgo: number
        """
        future = self.__client.Trade.Trade_ticks(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)


class Withdraw:

    def __init__(self, client):
        self.__client = client

    def Withdraw_chance(self, **kwargs) -> dict:
        """
        [GET] 출금 가능 정보

        ## 해당 통화의 가능한 출금 정보를 확인한다.

        :param currency: Currency Symbol
        :type currency: str
        """
        future = self.__client.Withdraw.Withdraw_chance(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Withdraw_coin(self, **kwargs) -> dict:
        """
        [POST] 코인 출금하기

        ## 코인 출금을 요청한다.

        [NOTE] 바로출금 이용 시 유의사항

        업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다.
        반드시 주소를 확인 후 출금을 진행하시기 바랍니다.

        :param currency: Currency 코드
        :type currency: str

        :param amount: 출금 수량
        :type amount: str

        :param address: 출금 가능 주소에 등록된 출금 주소
        :type address: str

        :param secondary_address: 2차 출금 주소 (필요한 코인에 한해서) (optional)
        :type secondary_address: string

        :param transaction_type: 출금 유형 (optional)
        - default : 일반출금
        - internal : 바로출금
        :type transaction_type: str
        """
        future = self.__client.Withdraw.Withdraw_coin(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Withdraw_info(self, **kwargs) -> dict:
        """
        [GET] 개별 출금 조회

        ## 출금 UUID를 통해 개별 출금 정보를 조회한다.

        :param uuid: 출금 UUID (optional)
        :type uuid: str

        :param txid: 출금 TXID (optional)
        :type txid: str

        :param currency: Currency 코드 (optional)
        :type currency: str
        """
        future = self.__client.Withdraw.Withdraw_info(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Withdraw_info_all(self, **kwargs) -> dict:
        """
        [GET] 출금 리스트 조회

        ## 출금 리스트를 조회한다.

        :param currency: Currency 코드 (optional)
        :type currency: string

        :param state: 출금 상태 (optional)
        - submitting : 처리 중
        - submitted : 처리 완료
        - almost_accepted : 출금대기중
        - rejected : 거부
        - accepted : 승인됨
        - processing : 처리 중
        - done : 완료
        - canceled : 취소됨
        :type state: string

        :param uuids: 출금 UUID의 목록 (optional)
        :type uuids: list

        :param txids: 출금 TXID의 목록 (optional)
        :type txids: list

        :param limit: 개수 제한 (default: 100, max: 100) (optional)
        :type limit: number

        :param page: 페이지 수, default: 1 (optional)
        :type page: number

        :param order_by: 정렬 방식 (optional)
        - asc : 오름차순
        - desc : 내림차순 (default)
        :type order_by: str
        """
        future = self.__client.Withdraw.Withdraw_info_all(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)

    def Withdraw_krw(self, **kwargs) -> dict:
        """
        [POST] 원화 출금하기

        ## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다.

        :param amount: 출금 원화 수량
        :type amount: str
        """
        future = self.__client.Withdraw.Withdraw_krw(**kwargs)
        return HTTPFutureExtractor.future_extraction(future)
