# SWGTradeApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tradeTicker**](SWGTradeApi.md#tradeticker) | **GET** /ticker | 시세 Ticker 조회
[**tradeTicks**](SWGTradeApi.md#tradeticks) | **GET** /trades/ticks | 시세 체결 조회


# **tradeTicker**
```objc
-(NSURLSessionTask*) tradeTickerWithMarkets: (NSString*) markets
        completionHandler: (void (^)(NSObject* output, NSError* error)) handler;
```

시세 Ticker 조회

## 현재가 정보 요청 당시 종목의 스냅샷을 반환한다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* markets = @"markets_example"; // 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC) 

SWGTradeApi*apiInstance = [[SWGTradeApi alloc] init];

// 시세 Ticker 조회
[apiInstance tradeTickerWithMarkets:markets
          completionHandler: ^(NSObject* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGTradeApi->tradeTicker: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | **NSString***| 반점으로 구분되는 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 

### Return type

**NSObject***

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tradeTicks**
```objc
-(NSURLSessionTask*) tradeTicksWithMarket: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
    cursor: (NSString*) cursor
    daysAgo: (NSNumber*) daysAgo
        completionHandler: (void (^)(NSObject* output, NSError* error)) handler;
```

시세 체결 조회

## 최근 체결 내역 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* market = @"market_example"; // 마켓 코드 (ex. KRW-BTC, BTC-BCC) 
NSString* to = @"to_example"; // 마지막 체결 시각. 형식 : `[HHmmss 또는 HH:mm:ss]`. 비워서 요청시 가장 최근 데이터  (optional)
NSNumber* count = @8.14; // 체결 개수  (optional)
NSString* cursor = @"cursor_example"; // 페이지네이션 커서 (sequentialId) `sequential_id` 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  (optional)
NSNumber* daysAgo = @8.14; // 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  (optional)

SWGTradeApi*apiInstance = [[SWGTradeApi alloc] init];

// 시세 체결 조회
[apiInstance tradeTicksWithMarket:market
              to:to
              count:count
              cursor:cursor
              daysAgo:daysAgo
          completionHandler: ^(NSObject* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGTradeApi->tradeTicks: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **NSString***| 마켓 코드 (ex. KRW-BTC, BTC-BCC)  | 
 **to** | **NSString***| 마지막 체결 시각. 형식 : &#x60;[HHmmss 또는 HH:mm:ss]&#x60;. 비워서 요청시 가장 최근 데이터  | [optional] 
 **count** | **NSNumber***| 체결 개수  | [optional] 
 **cursor** | **NSString***| 페이지네이션 커서 (sequentialId) &#x60;sequential_id&#x60; 필드는 체결의 유일성 판단을 위한 근거로 쓰일 수 있습니다. 하지만 체결의 순서를 보장하지는 못합니다.  | [optional] 
 **daysAgo** | **NSNumber***| 최근 체결 날짜 기준 7일 이내의 이전 데이터 조회 가능. 비워서 요청 시 가장 최근 체결 날짜 반환. (범위: 1 ~ 7)  | [optional] 

### Return type

**NSObject***

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

