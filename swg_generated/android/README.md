# swagger-android-client

## Requirements

Building the API client library requires [Maven](https://maven.apache.org/) to be installed.

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn deploy
```

Refer to the [official documentation](https://maven.apache.org/plugins/maven-deploy-plugin/usage.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
    <groupId>io.swagger</groupId>
    <artifactId>swagger-android-client</artifactId>
    <version>1.0.0</version>
    <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "io.swagger:swagger-android-client:1.0.0"
```

### Others

At first generate the JAR by executing:

    mvn package

Then manually install the following JARs:

* target/swagger-android-client-1.0.0.jar
* target/lib/*.jar

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import io.swagger.client.api.APIKeyApi;

public class APIKeyApiExample {

    public static void main(String[] args) {
        APIKeyApi apiInstance = new APIKeyApi();
        try {
            List<APIKey> result = apiInstance.aPIKeyInfo();
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling APIKeyApi#aPIKeyInfo");
            e.printStackTrace();
        }
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *https://api.upbit.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*APIKeyApi* | [**aPIKeyInfo**](docs/APIKeyApi.md#aPIKeyInfo) | **GET** /api_keys | API 키 리스트 조회
*AccountApi* | [**accountInfo**](docs/AccountApi.md#accountInfo) | **GET** /accounts | 전체 계좌 조회
*AccountApi* | [**accountWallet**](docs/AccountApi.md#accountWallet) | **GET** /status/wallet | 입출금 현황
*CandleApi* | [**candleDays**](docs/CandleApi.md#candleDays) | **GET** /candles/days | 시세 캔들 조회 (일 단위)
*CandleApi* | [**candleMinutes**](docs/CandleApi.md#candleMinutes) | **GET** /candles/minutes/{unit} | 시세 캔들 조회 (분 단위)
*CandleApi* | [**candleMonth**](docs/CandleApi.md#candleMonth) | **GET** /candles/months | 시세 캔들 조회 (월 단위)
*CandleApi* | [**candleWeeks**](docs/CandleApi.md#candleWeeks) | **GET** /candles/weeks | 시세 캔들 조회 (주 단위)
*DepositApi* | [**depositCoinAddress**](docs/DepositApi.md#depositCoinAddress) | **GET** /deposits/coin_address | 개별 입금 주소 조회
*DepositApi* | [**depositCoinAddresses**](docs/DepositApi.md#depositCoinAddresses) | **GET** /deposits/coin_addresses | 전체 입금 주소 조회
*DepositApi* | [**depositGenerateCoinAddress**](docs/DepositApi.md#depositGenerateCoinAddress) | **POST** /deposits/generate_coin_address | 입금 주소 생성 요청
*DepositApi* | [**depositInfo**](docs/DepositApi.md#depositInfo) | **GET** /deposit | 개별 입금 조회
*DepositApi* | [**depositInfoAll**](docs/DepositApi.md#depositInfoAll) | **GET** /deposits | 입금 리스트 조회
*MarketApi* | [**marketInfoAll**](docs/MarketApi.md#marketInfoAll) | **GET** /market/all | 마켓 코드 조회
*OrderApi* | [**orderCancel**](docs/OrderApi.md#orderCancel) | **DELETE** /order | 주문 취소 접수
*OrderApi* | [**orderChance**](docs/OrderApi.md#orderChance) | **GET** /orders/chance | 주문 가능 정보
*OrderApi* | [**orderInfo**](docs/OrderApi.md#orderInfo) | **GET** /order | 개별 주문 조회
*OrderApi* | [**orderInfoAll**](docs/OrderApi.md#orderInfoAll) | **GET** /orders | 주문 리스트 조회
*OrderApi* | [**orderNew**](docs/OrderApi.md#orderNew) | **POST** /orders | 주문하기
*OrderApi* | [**orderOrderbook**](docs/OrderApi.md#orderOrderbook) | **GET** /orderbook | 시세 호가 정보(Orderbook) 조회
*TradeApi* | [**tradeTicker**](docs/TradeApi.md#tradeTicker) | **GET** /ticker | 시세 Ticker 조회
*TradeApi* | [**tradeTicks**](docs/TradeApi.md#tradeTicks) | **GET** /trades/ticks | 시세 체결 조회
*WithdrawApi* | [**withdrawChance**](docs/WithdrawApi.md#withdrawChance) | **GET** /withdraws/chance | 출금 가능 정보
*WithdrawApi* | [**withdrawCoin**](docs/WithdrawApi.md#withdrawCoin) | **POST** /withdraws/coin | 코인 출금하기
*WithdrawApi* | [**withdrawInfo**](docs/WithdrawApi.md#withdrawInfo) | **GET** /withdraw | 개별 출금 조회
*WithdrawApi* | [**withdrawInfoAll**](docs/WithdrawApi.md#withdrawInfoAll) | **GET** /withdraws | 출금 리스트 조회
*WithdrawApi* | [**withdrawKrw**](docs/WithdrawApi.md#withdrawKrw) | **POST** /withdraws/krw | 원화 출금하기


## Documentation for Models

 - [APIKey](docs/APIKey.md)
 - [Account](docs/Account.md)
 - [Ask](docs/Ask.md)
 - [AskAccount](docs/AskAccount.md)
 - [Bid](docs/Bid.md)
 - [BidAccount](docs/BidAccount.md)
 - [CandleDate](docs/CandleDate.md)
 - [CandleDays](docs/CandleDays.md)
 - [CandleMinutes](docs/CandleMinutes.md)
 - [Currency](docs/Currency.md)
 - [Deposit](docs/Deposit.md)
 - [DepositCompleteResponse](docs/DepositCompleteResponse.md)
 - [DepositTransferResponse](docs/DepositTransferResponse.md)
 - [Error](docs/Error.md)
 - [ErrorInfo](docs/ErrorInfo.md)
 - [Market](docs/Market.md)
 - [MarketInfo](docs/MarketInfo.md)
 - [MemberLevel](docs/MemberLevel.md)
 - [NewOrder](docs/NewOrder.md)
 - [Order](docs/Order.md)
 - [OrderChance](docs/OrderChance.md)
 - [OrderInfo](docs/OrderInfo.md)
 - [Orderbook](docs/Orderbook.md)
 - [OrderbookUnit](docs/OrderbookUnit.md)
 - [Ticker](docs/Ticker.md)
 - [Trade](docs/Trade.md)
 - [TradeTicks](docs/TradeTicks.md)
 - [Wallet](docs/Wallet.md)
 - [Withdraw](docs/Withdraw.md)
 - [WithdrawChance](docs/WithdrawChance.md)
 - [WithdrawCoin](docs/WithdrawCoin.md)
 - [WithdrawLimit](docs/WithdrawLimit.md)


## Documentation for Authorization

Authentication schemes defined for the API:
### Bearer

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author

ujhin942@gmail.com

