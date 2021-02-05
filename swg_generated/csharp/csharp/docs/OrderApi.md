# IO.Swagger.Api.OrderApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderCancel**](OrderApi.md#ordercancel) | **DELETE** /order | 주문 취소 접수
[**OrderChance**](OrderApi.md#orderchance) | **GET** /orders/chance | 주문 가능 정보
[**OrderInfo**](OrderApi.md#orderinfo) | **GET** /order | 개별 주문 조회
[**OrderInfoAll**](OrderApi.md#orderinfoall) | **GET** /orders | 주문 리스트 조회
[**OrderNew**](OrderApi.md#ordernew) | **POST** /orders | 주문하기
[**OrderOrderbook**](OrderApi.md#orderorderbook) | **GET** /orderbook | 시세 호가 정보(Orderbook) 조회


<a name="ordercancel"></a>
# **OrderCancel**
> Order OrderCancel (string uuid = null, string identifier = null)

주문 취소 접수

## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다.  **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderCancelExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi();
            var uuid = uuid_example;  // string | 취소할 주문의 UUID  (optional) 
            var identifier = identifier_example;  // string | 조회용 사용자 지정 값  (optional) 

            try
            {
                // 주문 취소 접수
                Order result = apiInstance.OrderCancel(uuid, identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderCancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| 취소할 주문의 UUID  | [optional] 
 **identifier** | **string**| 조회용 사용자 지정 값  | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderchance"></a>
# **OrderChance**
> OrderChance OrderChance (string market)

주문 가능 정보

## 마켓별 주문 가능 정보를 확인한다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderChanceExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi();
            var market = market_example;  // string | Market ID 

            try
            {
                // 주문 가능 정보
                OrderChance result = apiInstance.OrderChance(market);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderChance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| Market ID  | 

### Return type

[**OrderChance**](OrderChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderinfo"></a>
# **OrderInfo**
> OrderInfo OrderInfo (string uuid = null, string identifier = null)

개별 주문 조회

## 주문 UUID를 통해 개별 주문건을 조회한다.  **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi();
            var uuid = uuid_example;  // string | 주문 UUID  (optional) 
            var identifier = identifier_example;  // string | 조회용 사용자 지정 값  (optional) 

            try
            {
                // 개별 주문 조회
                OrderInfo result = apiInstance.OrderInfo(uuid, identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| 주문 UUID  | [optional] 
 **identifier** | **string**| 조회용 사용자 지정 값  | [optional] 

### Return type

[**OrderInfo**](OrderInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderinfoall"></a>
# **OrderInfoAll**
> List<Order> OrderInfoAll (string market = null, string state = null, List<string> states = null, List<string> uuids = null, List<string> identifiers = null, decimal? page = null, decimal? limit = null, string orderBy = null)

주문 리스트 조회

## 주문 리스트를 조회한다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderInfoAllExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi();
            var market = market_example;  // string | 마켓 아이디  (optional) 
            var state = state_example;  // string | 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소  (optional) 
            var states = new List<string>(); // List<string> | 주문 상태의 목록  (optional) 
            var uuids = new List<string>(); // List<string> | 주문 UUID의 목록  (optional) 
            var identifiers = new List<string>(); // List<string> | 주문 identifier의 목록  (optional) 
            var page = 8.14;  // decimal? | 페이지 수, default: 1  (optional) 
            var limit = 8.14;  // decimal? | 요청 개수, default: 100  (optional) 
            var orderBy = orderBy_example;  // string | 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  (optional) 

            try
            {
                // 주문 리스트 조회
                List&lt;Order&gt; result = apiInstance.OrderInfoAll(market, state, states, uuids, identifiers, page, limit, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderInfoAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| 마켓 아이디  | [optional] 
 **state** | **string**| 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소  | [optional] 
 **states** | [**List&lt;string&gt;**](string.md)| 주문 상태의 목록  | [optional] 
 **uuids** | [**List&lt;string&gt;**](string.md)| 주문 UUID의 목록  | [optional] 
 **identifiers** | [**List&lt;string&gt;**](string.md)| 주문 identifier의 목록  | [optional] 
 **page** | **decimal?**| 페이지 수, default: 1  | [optional] 
 **limit** | **decimal?**| 요청 개수, default: 100  | [optional] 
 **orderBy** | **string**| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**List<Order>**](Order.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordernew"></a>
# **OrderNew**
> NewOrder OrderNew (string market, string side, string ordType, string volume = null, string price = null, string identifier = null)

주문하기

## 주문 요청을 한다.  **NOTE**: 원화 마켓 가격 단위를 확인하세요.  원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요.  **NOTE**: identifier 파라미터 사용  `identifier`는 서비스에서 발급하는 `uuid`가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다. 해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다.  주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 `identifier` 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요.  **NOTE**: 시장가 주문  시장가 주문은 `ord_type` 필드를 `price` or `market` 으로 설정해야됩니다. 매수 주문의 경우 `ord_type`을 `price`로 설정하고 `volume`을 `null` 혹은 제외해야됩니다. 매도 주문의 경우 `ord_type`을 `market`로 설정하고 `price`을 `null` 혹은 제외해야됩니다. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderNewExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi();
            var market = market_example;  // string | 마켓 ID (필수) 
            var side = side_example;  // string | 주문 종류 (필수) - bid : 매수 - ask : 매도 
            var ordType = ordType_example;  // string | 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도) 
            var volume = volume_example;  // string | 주문량 (지정가, 시장가 매도 시 필수)  (optional)  (default to null)
            var price = price_example;  // string | 주문 가격. (지정가, 시장가 매수 시 필수)  ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)  (optional)  (default to null)
            var identifier = identifier_example;  // string | 조회용 사용자 지정값 (선택)  (optional) 

            try
            {
                // 주문하기
                NewOrder result = apiInstance.OrderNew(market, side, ordType, volume, price, identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderNew: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **string**| 마켓 ID (필수)  | 
 **side** | **string**| 주문 종류 (필수) - bid : 매수 - ask : 매도  | 
 **ordType** | **string**| 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도)  | 
 **volume** | **string**| 주문량 (지정가, 시장가 매도 시 필수)  | [optional] [default to null]
 **price** | **string**| 주문 가격. (지정가, 시장가 매수 시 필수)  ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)  | [optional] [default to null]
 **identifier** | **string**| 조회용 사용자 지정값 (선택)  | [optional] 

### Return type

[**NewOrder**](NewOrder.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderorderbook"></a>
# **OrderOrderbook**
> List<Orderbook> OrderOrderbook (List<string> markets)

시세 호가 정보(Orderbook) 조회

## 호가 정보 조회 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderOrderbookExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi();
            var markets = new List<string>(); // List<string> | 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA) 

            try
            {
                // 시세 호가 정보(Orderbook) 조회
                List&lt;Orderbook&gt; result = apiInstance.OrderOrderbook(markets);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderOrderbook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | [**List&lt;string&gt;**](string.md)| 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA)  | 

### Return type

[**List<Orderbook>**](Orderbook.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

