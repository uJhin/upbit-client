# SWGCandleApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**candleDays**](SWGCandleApi.md#candledays) | **GET** /candles/days | 시세 캔들 조회 (일 단위)
[**candleMinutes**](SWGCandleApi.md#candleminutes) | **GET** /candles/minutes/{unit} | 시세 캔들 조회 (분 단위)
[**candleMonth**](SWGCandleApi.md#candlemonth) | **GET** /candles/months | 시세 캔들 조회 (월 단위)
[**candleWeeks**](SWGCandleApi.md#candleweeks) | **GET** /candles/weeks | 시세 캔들 조회 (주 단위)


# **candleDays**
```objc
-(NSURLSessionTask*) candleDaysWithMarket: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
    convertingPriceUnit: (NSString*) convertingPriceUnit
        completionHandler: (void (^)(NSObject* output, NSError* error)) handler;
```

시세 캔들 조회 (일 단위)

## 일(Day) 캔들 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* market = @"market_example"; // 마켓 코드 (ex. KRW-BTC) 
NSString* to = @"to_example"; // 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
NSNumber* count = @8.14; // 캔들 개수  (optional)
NSString* convertingPriceUnit = @"KRW"; // 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)  `convertingPriceUnit` 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 `converted_trade_price` 필드에 추가하여 반환합니다. 현재는 원화(`KRW`) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다.  (optional) (default to KRW)

SWGCandleApi*apiInstance = [[SWGCandleApi alloc] init];

// 시세 캔들 조회 (일 단위)
[apiInstance candleDaysWithMarket:market
              to:to
              count:count
              convertingPriceUnit:convertingPriceUnit
          completionHandler: ^(NSObject* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGCandleApi->candleDays: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **NSString***| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **NSString***| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **NSNumber***| 캔들 개수  | [optional] 
 **convertingPriceUnit** | **NSString***| 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)  &#x60;convertingPriceUnit&#x60; 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 &#x60;converted_trade_price&#x60; 필드에 추가하여 반환합니다. 현재는 원화(&#x60;KRW&#x60;) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다.  | [optional] [default to KRW]

### Return type

**NSObject***

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **candleMinutes**
```objc
-(NSURLSessionTask*) candleMinutesWithUnit: (NSNumber*) unit
    market: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
        completionHandler: (void (^)(NSObject* output, NSError* error)) handler;
```

시세 캔들 조회 (분 단위)

## 분(Minute) 캔들 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSNumber* unit = @56; // 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240 
NSString* market = @"market_example"; // 마켓 코드 (ex. KRW-BTC) 
NSString* to = @"to_example"; // 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
NSNumber* count = @8.14; // 캔들 개수 (최대 200개까지 요청 가능)  (optional)

SWGCandleApi*apiInstance = [[SWGCandleApi alloc] init];

// 시세 캔들 조회 (분 단위)
[apiInstance candleMinutesWithUnit:unit
              market:market
              to:to
              count:count
          completionHandler: ^(NSObject* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGCandleApi->candleMinutes: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unit** | **NSNumber***| 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240  | 
 **market** | **NSString***| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **NSString***| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **NSNumber***| 캔들 개수 (최대 200개까지 요청 가능)  | [optional] 

### Return type

**NSObject***

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **candleMonth**
```objc
-(NSURLSessionTask*) candleMonthWithMarket: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
        completionHandler: (void (^)(NSObject* output, NSError* error)) handler;
```

시세 캔들 조회 (월 단위)

## 월(Month) 캔들 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* market = @"market_example"; // 마켓 코드 (ex. KRW-BTC) 
NSString* to = @"to_example"; // 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
NSNumber* count = @8.14; // 캔들 개수  (optional)

SWGCandleApi*apiInstance = [[SWGCandleApi alloc] init];

// 시세 캔들 조회 (월 단위)
[apiInstance candleMonthWithMarket:market
              to:to
              count:count
          completionHandler: ^(NSObject* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGCandleApi->candleMonth: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **NSString***| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **NSString***| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **NSNumber***| 캔들 개수  | [optional] 

### Return type

**NSObject***

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **candleWeeks**
```objc
-(NSURLSessionTask*) candleWeeksWithMarket: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
        completionHandler: (void (^)(NSObject* output, NSError* error)) handler;
```

시세 캔들 조회 (주 단위)

## 주(Week) 캔들 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* market = @"market_example"; // 마켓 코드 (ex. KRW-BTC) 
NSString* to = @"to_example"; // 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
NSNumber* count = @8.14; // 캔들 개수  (optional)

SWGCandleApi*apiInstance = [[SWGCandleApi alloc] init];

// 시세 캔들 조회 (주 단위)
[apiInstance candleWeeksWithMarket:market
              to:to
              count:count
          completionHandler: ^(NSObject* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGCandleApi->candleWeeks: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **NSString***| 마켓 코드 (ex. KRW-BTC)  | 
 **to** | **NSString***| 마지막 캔들 시각 (exclusive). 포맷 : &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&#x60; or &#x60;yyyy-MM-dd HH:mm:ss&#x60;. 비워서 요청 시 가장 최근 캔들  | [optional] 
 **count** | **NSNumber***| 캔들 개수  | [optional] 

### Return type

**NSObject***

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

