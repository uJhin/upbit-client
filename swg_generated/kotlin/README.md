# io.swagger.client - Kotlin client library for Upbit Open API

## Requires

* Kotlin 1.1.2
* Gradle 3.3

## Build

First, create the gradle wrapper script:

```
gradle wrapper
```

Then, run:

```
./gradlew check assemble
```

This runs all tests and packages the library.

## Features/Implementation Notes

* Supports JSON inputs/outputs, File inputs, and Form inputs.
* Supports collection formats for query parameters: csv, tsv, ssv, pipes.
* Some Kotlin and Java types are fully qualified to avoid conflicts with types defined in Swagger definitions.
* Implementation of ApiClient is intended to reduce method counts, specifically to benefit Android targets.

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.upbit.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*APIKeyApi* | [**aPIKey.info**](docs/APIKeyApi.md#apikey.info) | **GET** /api_keys | API 키 리스트 조회
*AccountApi* | [**account.info**](docs/AccountApi.md#account.info) | **GET** /accounts | 전체 계좌 조회
*AccountApi* | [**account.wallet**](docs/AccountApi.md#account.wallet) | **GET** /status/wallet | 입출금 현황
*CandleApi* | [**candle.days**](docs/CandleApi.md#candle.days) | **GET** /candles/days | 시세 캔들 조회 (일 단위)
*CandleApi* | [**candle.minutes**](docs/CandleApi.md#candle.minutes) | **GET** /candles/minutes/{unit} | 시세 캔들 조회 (분 단위)
*CandleApi* | [**candle.month**](docs/CandleApi.md#candle.month) | **GET** /candles/months | 시세 캔들 조회 (월 단위)
*CandleApi* | [**candle.weeks**](docs/CandleApi.md#candle.weeks) | **GET** /candles/weeks | 시세 캔들 조회 (주 단위)
*DepositApi* | [**deposit.coinAddress**](docs/DepositApi.md#deposit.coinaddress) | **GET** /deposits/coin_address | 개별 입금 주소 조회
*DepositApi* | [**deposit.coinAddresses**](docs/DepositApi.md#deposit.coinaddresses) | **GET** /deposits/coin_addresses | 전체 입금 주소 조회
*DepositApi* | [**deposit.generateCoinAddress**](docs/DepositApi.md#deposit.generatecoinaddress) | **POST** /deposits/generate_coin_address | 입금 주소 생성 요청
*DepositApi* | [**deposit.info**](docs/DepositApi.md#deposit.info) | **GET** /deposit | 개별 입금 조회
*DepositApi* | [**deposit.infoAll**](docs/DepositApi.md#deposit.infoall) | **GET** /deposits | 입금 리스트 조회
*MarketApi* | [**market.infoAll**](docs/MarketApi.md#market.infoall) | **GET** /market/all | 마켓 코드 조회
*OrderApi* | [**order.cancel**](docs/OrderApi.md#order.cancel) | **DELETE** /order | 주문 취소 접수
*OrderApi* | [**order.chance**](docs/OrderApi.md#order.chance) | **GET** /orders/chance | 주문 가능 정보
*OrderApi* | [**order.info**](docs/OrderApi.md#order.info) | **GET** /order | 개별 주문 조회
*OrderApi* | [**order.infoAll**](docs/OrderApi.md#order.infoall) | **GET** /orders | 주문 리스트 조회
*OrderApi* | [**order.new**](docs/OrderApi.md#order.new) | **POST** /orders | 주문하기
*OrderApi* | [**order.orderbook**](docs/OrderApi.md#order.orderbook) | **GET** /orderbook | 시세 호가 정보(Orderbook) 조회
*TradeApi* | [**trade.ticker**](docs/TradeApi.md#trade.ticker) | **GET** /ticker | 시세 Ticker 조회
*TradeApi* | [**trade.ticks**](docs/TradeApi.md#trade.ticks) | **GET** /trades/ticks | 시세 체결 조회
*WithdrawApi* | [**withdraw.chance**](docs/WithdrawApi.md#withdraw.chance) | **GET** /withdraws/chance | 출금 가능 정보
*WithdrawApi* | [**withdraw.coin**](docs/WithdrawApi.md#withdraw.coin) | **POST** /withdraws/coin | 코인 출금하기
*WithdrawApi* | [**withdraw.info**](docs/WithdrawApi.md#withdraw.info) | **GET** /withdraw | 개별 출금 조회
*WithdrawApi* | [**withdraw.infoAll**](docs/WithdrawApi.md#withdraw.infoall) | **GET** /withdraws | 출금 리스트 조회
*WithdrawApi* | [**withdraw.krw**](docs/WithdrawApi.md#withdraw.krw) | **POST** /withdraws/krw | 원화 출금하기


<a name="documentation-for-models"></a>
## Documentation for Models

 - [io.swagger.client.models.APIKey](docs/APIKey.md)
 - [io.swagger.client.models.Account](docs/Account.md)
 - [io.swagger.client.models.Ask](docs/Ask.md)
 - [io.swagger.client.models.AskAccount](docs/AskAccount.md)
 - [io.swagger.client.models.Bid](docs/Bid.md)
 - [io.swagger.client.models.BidAccount](docs/BidAccount.md)
 - [io.swagger.client.models.CandleDate](docs/CandleDate.md)
 - [io.swagger.client.models.CandleDays](docs/CandleDays.md)
 - [io.swagger.client.models.CandleMinutes](docs/CandleMinutes.md)
 - [io.swagger.client.models.Currency](docs/Currency.md)
 - [io.swagger.client.models.Deposit](docs/Deposit.md)
 - [io.swagger.client.models.DepositCompleteResponse](docs/DepositCompleteResponse.md)
 - [io.swagger.client.models.DepositTransferResponse](docs/DepositTransferResponse.md)
 - [io.swagger.client.models.Error](docs/Error.md)
 - [io.swagger.client.models.ErrorInfo](docs/ErrorInfo.md)
 - [io.swagger.client.models.Market](docs/Market.md)
 - [io.swagger.client.models.MarketInfo](docs/MarketInfo.md)
 - [io.swagger.client.models.MemberLevel](docs/MemberLevel.md)
 - [io.swagger.client.models.NewOrder](docs/NewOrder.md)
 - [io.swagger.client.models.Order](docs/Order.md)
 - [io.swagger.client.models.OrderChance](docs/OrderChance.md)
 - [io.swagger.client.models.OrderInfo](docs/OrderInfo.md)
 - [io.swagger.client.models.Orderbook](docs/Orderbook.md)
 - [io.swagger.client.models.OrderbookUnit](docs/OrderbookUnit.md)
 - [io.swagger.client.models.Ticker](docs/Ticker.md)
 - [io.swagger.client.models.Trade](docs/Trade.md)
 - [io.swagger.client.models.TradeTicks](docs/TradeTicks.md)
 - [io.swagger.client.models.Wallet](docs/Wallet.md)
 - [io.swagger.client.models.Withdraw](docs/Withdraw.md)
 - [io.swagger.client.models.WithdrawChance](docs/WithdrawChance.md)
 - [io.swagger.client.models.WithdrawCoin](docs/WithdrawCoin.md)
 - [io.swagger.client.models.WithdrawLimit](docs/WithdrawLimit.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

