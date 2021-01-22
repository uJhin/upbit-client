# SWGDepositApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**depositCoinAddress**](SWGDepositApi.md#depositcoinaddress) | **GET** /deposits/coin_address | 개별 입금 주소 조회
[**depositCoinAddresses**](SWGDepositApi.md#depositcoinaddresses) | **GET** /deposits/coin_addresses | 전체 입금 주소 조회
[**depositGenerateCoinAddress**](SWGDepositApi.md#depositgeneratecoinaddress) | **POST** /deposits/generate_coin_address | 입금 주소 생성 요청
[**depositInfo**](SWGDepositApi.md#depositinfo) | **GET** /deposit | 개별 입금 조회
[**depositInfoAll**](SWGDepositApi.md#depositinfoall) | **GET** /deposits | 입금 리스트 조회


# **depositCoinAddress**
```objc
-(NSURLSessionTask*) depositCoinAddressWithCurrency: (NSString*) currency
        completionHandler: (void (^)(SWGDepositCompleteResponse* output, NSError* error)) handler;
```

개별 입금 주소 조회

## 개별 입금 주소 조회  **NOTE**: 입금 주소 조회 요청 API 유의사항  입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* currency = @"currency_example"; // Currency symbol 

SWGDepositApi*apiInstance = [[SWGDepositApi alloc] init];

// 개별 입금 주소 조회
[apiInstance depositCoinAddressWithCurrency:currency
          completionHandler: ^(SWGDepositCompleteResponse* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGDepositApi->depositCoinAddress: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **NSString***| Currency symbol  | 

### Return type

[**SWGDepositCompleteResponse***](SWGDepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **depositCoinAddresses**
```objc
-(NSURLSessionTask*) depositCoinAddressesWithCompletionHandler: 
        (void (^)(NSObject* output, NSError* error)) handler;
```

전체 입금 주소 조회

## 내가 보유한 자산 리스트를 보여줍니다.  **NOTE**: 입금 주소 조회 요청 API 유의사항  입금 주소 생성 요청 이후 아직 발급되지 않은 상태일 경우 deposit_address가 null일 수 있습니다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];



SWGDepositApi*apiInstance = [[SWGDepositApi alloc] init];

// 전체 입금 주소 조회
[apiInstance depositCoinAddressesWithCompletionHandler: 
          ^(NSObject* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGDepositApi->depositCoinAddresses: %@", error);
                        }
                    }];
```

### Parameters
This endpoint does not need any parameter.

### Return type

**NSObject***

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **depositGenerateCoinAddress**
```objc
-(NSURLSessionTask*) depositGenerateCoinAddressWithCurrency: (NSString*) currency
        completionHandler: (void (^)(SWGDepositCompleteResponse* output, NSError* error)) handler;
```

입금 주소 생성 요청

입금 주소 생성을 요청한다.  **NOTE**: 입금 주소 생성 요청 API 유의사항  입금 주소의 생성은 서버에서 비동기적으로 이뤄집니다. 비동기적 생성 특성상 요청과 동시에 입금 주소가 발급되지 않을 수 있습니다. 주소 발급 요청 시 결과로 Response1이 반환되며 주소 발급 완료 이전까지 계속 Response1이 반환됩니다. 주소가 발급된 이후부터는 새로운 주소가 발급되는 것이 아닌 이전에 발급된 주소가 Response2 형태로 반환됩니다. 정상적으로 주소가 생성되지 않는다면 일정 시간 이후 해당 API를 다시 호출해주시길 부탁드립니다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* currency = @"currency_example"; // Currency 코드 

SWGDepositApi*apiInstance = [[SWGDepositApi alloc] init];

// 입금 주소 생성 요청
[apiInstance depositGenerateCoinAddressWithCurrency:currency
          completionHandler: ^(SWGDepositCompleteResponse* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGDepositApi->depositGenerateCoinAddress: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **NSString***| Currency 코드  | 

### Return type

[**SWGDepositCompleteResponse***](SWGDepositCompleteResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **depositInfo**
```objc
-(NSURLSessionTask*) depositInfoWithUuid: (NSString*) uuid
    txid: (NSString*) txid
    currency: (NSString*) currency
        completionHandler: (void (^)(SWGDeposit* output, NSError* error)) handler;
```

개별 입금 조회

## 개별 입금 조회 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* uuid = @"uuid_example"; // 입금 UUID  (optional)
NSString* txid = @"txid_example"; // 입금 TXID  (optional)
NSString* currency = @"currency_example"; // Currency 코드  (optional)

SWGDepositApi*apiInstance = [[SWGDepositApi alloc] init];

// 개별 입금 조회
[apiInstance depositInfoWithUuid:uuid
              txid:txid
              currency:currency
          completionHandler: ^(SWGDeposit* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGDepositApi->depositInfo: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **NSString***| 입금 UUID  | [optional] 
 **txid** | **NSString***| 입금 TXID  | [optional] 
 **currency** | **NSString***| Currency 코드  | [optional] 

### Return type

[**SWGDeposit***](SWGDeposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **depositInfoAll**
```objc
-(NSURLSessionTask*) depositInfoAllWithCurrency: (NSString*) currency
    state: (NSString*) state
    uuids: (NSArray<NSString*>*) uuids
    txids: (NSArray<NSString*>*) txids
    limit: (NSNumber*) limit
    page: (NSNumber*) page
    orderBy: (NSString*) orderBy
        completionHandler: (void (^)(NSArray<SWGDeposit>* output, NSError* error)) handler;
```

입금 리스트 조회

## 입금 리스트 조회 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* currency = @"currency_example"; // Currency 코드  (optional)
NSString* state = @"state_example"; // 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중  (optional)
NSArray<NSString*>* uuids = @[@"uuids_example"]; // 입금 UUID의 목록  (optional)
NSArray<NSString*>* txids = @[@"txids_example"]; // 입금 TXID의 목록  (optional)
NSNumber* limit = @8.14; // 개수 제한 (default: 100, max: 100)  (optional)
NSNumber* page = @8.14; // 페이지 수, default: 1  (optional)
NSString* orderBy = @"orderBy_example"; // 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  (optional)

SWGDepositApi*apiInstance = [[SWGDepositApi alloc] init];

// 입금 리스트 조회
[apiInstance depositInfoAllWithCurrency:currency
              state:state
              uuids:uuids
              txids:txids
              limit:limit
              page:page
              orderBy:orderBy
          completionHandler: ^(NSArray<SWGDeposit>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGDepositApi->depositInfoAll: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **NSString***| Currency 코드  | [optional] 
 **state** | **NSString***| 출금 상태 - submitting : 처리 중 - submitted : 처리완료 - almost_accepted : 입금 대기 중 - rejected : 거절 - accepted : 승인됨 - processing : 처리 중  | [optional] 
 **uuids** | [**NSArray&lt;NSString*&gt;***](NSString*.md)| 입금 UUID의 목록  | [optional] 
 **txids** | [**NSArray&lt;NSString*&gt;***](NSString*.md)| 입금 TXID의 목록  | [optional] 
 **limit** | **NSNumber***| 개수 제한 (default: 100, max: 100)  | [optional] 
 **page** | **NSNumber***| 페이지 수, default: 1  | [optional] 
 **orderBy** | **NSString***| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**NSArray<SWGDeposit>***](SWGDeposit.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

