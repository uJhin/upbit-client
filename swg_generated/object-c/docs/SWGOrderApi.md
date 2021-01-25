# SWGOrderApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**orderCancel**](SWGOrderApi.md#ordercancel) | **DELETE** /order | 주문 취소 접수
[**orderChance**](SWGOrderApi.md#orderchance) | **GET** /orders/chance | 주문 가능 정보
[**orderInfo**](SWGOrderApi.md#orderinfo) | **GET** /order | 개별 주문 조회
[**orderInfoAll**](SWGOrderApi.md#orderinfoall) | **GET** /orders | 주문 리스트 조회
[**orderNew**](SWGOrderApi.md#ordernew) | **POST** /orders | 주문하기
[**orderOrderbook**](SWGOrderApi.md#orderorderbook) | **GET** /orderbook | 시세 호가 정보(Orderbook) 조회


# **orderCancel**
```objc
-(NSURLSessionTask*) orderCancelWithUuid: (NSString*) uuid
    identifier: (NSString*) identifier
        completionHandler: (void (^)(SWGOrder* output, NSError* error)) handler;
```

주문 취소 접수

## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다. **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* uuid = @"uuid_example"; // 취소할 주문의 UUID  (optional)
NSString* identifier = @"identifier_example"; // 조회용 사용자 지정 값  (optional)

SWGOrderApi*apiInstance = [[SWGOrderApi alloc] init];

// 주문 취소 접수
[apiInstance orderCancelWithUuid:uuid
              identifier:identifier
          completionHandler: ^(SWGOrder* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGOrderApi->orderCancel: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **NSString***| 취소할 주문의 UUID  | [optional] 
 **identifier** | **NSString***| 조회용 사용자 지정 값  | [optional] 

### Return type

[**SWGOrder***](SWGOrder.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderChance**
```objc
-(NSURLSessionTask*) orderChanceWithMarket: (NSString*) market
        completionHandler: (void (^)(SWGOrderChance* output, NSError* error)) handler;
```

주문 가능 정보

## 마켓별 주문 가능 정보를 확인한다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* market = @"market_example"; // Market ID 

SWGOrderApi*apiInstance = [[SWGOrderApi alloc] init];

// 주문 가능 정보
[apiInstance orderChanceWithMarket:market
          completionHandler: ^(SWGOrderChance* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGOrderApi->orderChance: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **NSString***| Market ID  | 

### Return type

[**SWGOrderChance***](SWGOrderChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderInfo**
```objc
-(NSURLSessionTask*) orderInfoWithUuid: (NSString*) uuid
    identifier: (NSString*) identifier
        completionHandler: (void (^)(SWGOrderInfo* output, NSError* error)) handler;
```

개별 주문 조회

## 주문 UUID를 통해 개별 주문건을 조회한다. **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* uuid = @"uuid_example"; // 주문 UUID  (optional)
NSString* identifier = @"identifier_example"; // 조회용 사용자 지정 값  (optional)

SWGOrderApi*apiInstance = [[SWGOrderApi alloc] init];

// 개별 주문 조회
[apiInstance orderInfoWithUuid:uuid
              identifier:identifier
          completionHandler: ^(SWGOrderInfo* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGOrderApi->orderInfo: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **NSString***| 주문 UUID  | [optional] 
 **identifier** | **NSString***| 조회용 사용자 지정 값  | [optional] 

### Return type

[**SWGOrderInfo***](SWGOrderInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderInfoAll**
```objc
-(NSURLSessionTask*) orderInfoAllWithMarket: (NSString*) market
    state: (NSString*) state
    states: (NSArray<NSString*>*) states
    uuids: (NSArray<NSString*>*) uuids
    identifiers: (NSArray<NSString*>*) identifiers
    page: (NSNumber*) page
    limit: (NSNumber*) limit
    orderBy: (NSString*) orderBy
        completionHandler: (void (^)(NSArray<SWGOrder>* output, NSError* error)) handler;
```

주문 리스트 조회

## 주문 리스트를 조회한다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* market = @"market_example"; // 마켓 아이디  (optional)
NSString* state = @"state_example"; // 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소  (optional)
NSArray<NSString*>* states = @[@"states_example"]; // 주문 상태의 목록  (optional)
NSArray<NSString*>* uuids = @[@"uuids_example"]; // 주문 UUID의 목록  (optional)
NSArray<NSString*>* identifiers = @[@"identifiers_example"]; // 주문 identifier의 목록  (optional)
NSNumber* page = @8.14; // 페이지 수, default: 1  (optional)
NSNumber* limit = @8.14; // 요청 개수, default: 100  (optional)
NSString* orderBy = @"orderBy_example"; // 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  (optional)

SWGOrderApi*apiInstance = [[SWGOrderApi alloc] init];

// 주문 리스트 조회
[apiInstance orderInfoAllWithMarket:market
              state:state
              states:states
              uuids:uuids
              identifiers:identifiers
              page:page
              limit:limit
              orderBy:orderBy
          completionHandler: ^(NSArray<SWGOrder>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGOrderApi->orderInfoAll: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **NSString***| 마켓 아이디  | [optional] 
 **state** | **NSString***| 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소  | [optional] 
 **states** | [**NSArray&lt;NSString*&gt;***](NSString*.md)| 주문 상태의 목록  | [optional] 
 **uuids** | [**NSArray&lt;NSString*&gt;***](NSString*.md)| 주문 UUID의 목록  | [optional] 
 **identifiers** | [**NSArray&lt;NSString*&gt;***](NSString*.md)| 주문 identifier의 목록  | [optional] 
 **page** | **NSNumber***| 페이지 수, default: 1  | [optional] 
 **limit** | **NSNumber***| 요청 개수, default: 100  | [optional] 
 **orderBy** | **NSString***| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**NSArray<SWGOrder>***](SWGOrder.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderNew**
```objc
-(NSURLSessionTask*) orderNewWithMarket: (NSString*) market
    side: (NSString*) side
    ordType: (NSString*) ordType
    volume: (NSString*) volume
    price: (NSString*) price
    identifier: (NSString*) identifier
        completionHandler: (void (^)(SWGNewOrder* output, NSError* error)) handler;
```

주문하기

## 주문 요청을 한다. **NOTE**: 원화 마켓 가격 단위를 확인하세요. 원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요. **NOTE**: identifier 파라미터 사용 `identifier`는 서비스에서 발급하는 `uuid`가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다. 해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다. 주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 `identifier` 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요. **NOTE**: 시장가 주문 시장가 주문은 `ord_type` 필드를 `price` or `market` 으로 설정해야됩니다. 매수 주문의 경우 `ord_type`을 `price`로 설정하고 `volume`을 `null` 혹은 제외해야됩니다. 매도 주문의 경우 `ord_type`을 `market`로 설정하고 `price`을 `null` 혹은 제외해야됩니다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* market = @"market_example"; // 마켓 ID (필수) 
NSString* side = @"side_example"; // 주문 종류 (필수) - bid : 매수 - ask : 매도 
NSString* ordType = @"ordType_example"; // 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도) 
NSString* volume = @"null"; // 주문량 (지정가, 시장가 매도 시 필수)  (optional) (default to null)
NSString* price = @"null"; // 주문 가격. (지정가, 시장가 매수 시 필수) ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)  (optional) (default to null)
NSString* identifier = @"identifier_example"; // 조회용 사용자 지정값 (선택)  (optional)

SWGOrderApi*apiInstance = [[SWGOrderApi alloc] init];

// 주문하기
[apiInstance orderNewWithMarket:market
              side:side
              ordType:ordType
              volume:volume
              price:price
              identifier:identifier
          completionHandler: ^(SWGNewOrder* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGOrderApi->orderNew: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **market** | **NSString***| 마켓 ID (필수)  | 
 **side** | **NSString***| 주문 종류 (필수) - bid : 매수 - ask : 매도  | 
 **ordType** | **NSString***| 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도)  | 
 **volume** | **NSString***| 주문량 (지정가, 시장가 매도 시 필수)  | [optional] [default to null]
 **price** | **NSString***| 주문 가격. (지정가, 시장가 매수 시 필수) ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)  | [optional] [default to null]
 **identifier** | **NSString***| 조회용 사용자 지정값 (선택)  | [optional] 

### Return type

[**SWGNewOrder***](SWGNewOrder.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, multipart/form-data, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderOrderbook**
```objc
-(NSURLSessionTask*) orderOrderbookWithMarkets: (NSArray<NSString*>*) markets
        completionHandler: (void (^)(NSArray<SWGOrderbook>* output, NSError* error)) handler;
```

시세 호가 정보(Orderbook) 조회

## 호가 정보 조회 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSArray<NSString*>* markets = @[@"markets_example"]; // 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA) 

SWGOrderApi*apiInstance = [[SWGOrderApi alloc] init];

// 시세 호가 정보(Orderbook) 조회
[apiInstance orderOrderbookWithMarkets:markets
          completionHandler: ^(NSArray<SWGOrderbook>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGOrderApi->orderOrderbook: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markets** | [**NSArray&lt;NSString*&gt;***](NSString*.md)| 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA)  | 

### Return type

[**NSArray<SWGOrderbook>***](SWGOrderbook.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

