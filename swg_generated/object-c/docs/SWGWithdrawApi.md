# SWGWithdrawApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**withdrawChance**](SWGWithdrawApi.md#withdrawchance) | **GET** /withdraws/chance | 출금 가능 정보
[**withdrawCoin**](SWGWithdrawApi.md#withdrawcoin) | **POST** /withdraws/coin | 코인 출금하기
[**withdrawInfo**](SWGWithdrawApi.md#withdrawinfo) | **GET** /withdraw | 개별 출금 조회
[**withdrawInfoAll**](SWGWithdrawApi.md#withdrawinfoall) | **GET** /withdraws | 출금 리스트 조회
[**withdrawKrw**](SWGWithdrawApi.md#withdrawkrw) | **POST** /withdraws/krw | 원화 출금하기


# **withdrawChance**
```objc
-(NSURLSessionTask*) withdrawChanceWithCurrency: (NSString*) currency
        completionHandler: (void (^)(SWGWithdrawChance* output, NSError* error)) handler;
```

출금 가능 정보

## 해당 통화의 가능한 출금 정보를 확인한다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* currency = @"currency_example"; // Currency Symbol 

SWGWithdrawApi*apiInstance = [[SWGWithdrawApi alloc] init];

// 출금 가능 정보
[apiInstance withdrawChanceWithCurrency:currency
          completionHandler: ^(SWGWithdrawChance* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGWithdrawApi->withdrawChance: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **NSString***| Currency Symbol  | 

### Return type

[**SWGWithdrawChance***](SWGWithdrawChance.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdrawCoin**
```objc
-(NSURLSessionTask*) withdrawCoinWithCurrency: (NSString*) currency
    amount: (NSString*) amount
    address: (NSString*) address
    secondaryAddress: (NSString*) secondaryAddress
    transactionType: (NSString*) transactionType
        completionHandler: (void (^)(SWGWithdrawCoin* output, NSError* error)) handler;
```

코인 출금하기

## 코인 출금을 요청한다. **NOTE**: 바로출금 이용 시 유의사항 업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* currency = @"currency_example"; // Currency 코드 
NSString* amount = @"amount_example"; // 출금 수량 
NSString* address = @"address_example"; // 출금 가능 주소에 등록된 출금 주소 
NSString* secondaryAddress = @"secondaryAddress_example"; // 2차 출금 주소 (필요한 코인에 한해서)  (optional)
NSString* transactionType = @"transactionType_example"; // 출금 유형 - default : 일반출금 - internal : 바로출금  (optional)

SWGWithdrawApi*apiInstance = [[SWGWithdrawApi alloc] init];

// 코인 출금하기
[apiInstance withdrawCoinWithCurrency:currency
              amount:amount
              address:address
              secondaryAddress:secondaryAddress
              transactionType:transactionType
          completionHandler: ^(SWGWithdrawCoin* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGWithdrawApi->withdrawCoin: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **NSString***| Currency 코드  | 
 **amount** | **NSString***| 출금 수량  | 
 **address** | **NSString***| 출금 가능 주소에 등록된 출금 주소  | 
 **secondaryAddress** | **NSString***| 2차 출금 주소 (필요한 코인에 한해서)  | [optional] 
 **transactionType** | **NSString***| 출금 유형 - default : 일반출금 - internal : 바로출금  | [optional] 

### Return type

[**SWGWithdrawCoin***](SWGWithdrawCoin.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdrawInfo**
```objc
-(NSURLSessionTask*) withdrawInfoWithUuid: (NSString*) uuid
    txid: (NSString*) txid
    currency: (NSString*) currency
        completionHandler: (void (^)(SWGWithdraw* output, NSError* error)) handler;
```

개별 출금 조회

## 출금 UUID를 통해 개별 출금 정보를 조회한다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* uuid = @"uuid_example"; // 출금 UUID  (optional)
NSString* txid = @"txid_example"; // 출금 TXID  (optional)
NSString* currency = @"currency_example"; // Currency 코드  (optional)

SWGWithdrawApi*apiInstance = [[SWGWithdrawApi alloc] init];

// 개별 출금 조회
[apiInstance withdrawInfoWithUuid:uuid
              txid:txid
              currency:currency
          completionHandler: ^(SWGWithdraw* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGWithdrawApi->withdrawInfo: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **NSString***| 출금 UUID  | [optional] 
 **txid** | **NSString***| 출금 TXID  | [optional] 
 **currency** | **NSString***| Currency 코드  | [optional] 

### Return type

[**SWGWithdraw***](SWGWithdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdrawInfoAll**
```objc
-(NSURLSessionTask*) withdrawInfoAllWithCurrency: (NSString*) currency
    state: (NSString*) state
    uuids: (NSArray<NSString*>*) uuids
    txids: (NSArray<NSString*>*) txids
    limit: (NSNumber*) limit
    page: (NSNumber*) page
    orderBy: (NSString*) orderBy
        completionHandler: (void (^)(NSArray<SWGWithdraw>* output, NSError* error)) handler;
```

출금 리스트 조회

## 출금 리스트를 조회한다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* currency = @"currency_example"; // Currency 코드  (optional)
NSString* state = @"state_example"; // 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  (optional)
NSArray<NSString*>* uuids = @[@"uuids_example"]; // 출금 UUID의 목록  (optional)
NSArray<NSString*>* txids = @[@"txids_example"]; // 출금 TXID의 목록  (optional)
NSNumber* limit = @8.14; // 개수 제한 (default: 100, max: 100)  (optional)
NSNumber* page = @8.14; // 페이지 수, default: 1  (optional)
NSString* orderBy = @"orderBy_example"; // 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  (optional)

SWGWithdrawApi*apiInstance = [[SWGWithdrawApi alloc] init];

// 출금 리스트 조회
[apiInstance withdrawInfoAllWithCurrency:currency
              state:state
              uuids:uuids
              txids:txids
              limit:limit
              page:page
              orderBy:orderBy
          completionHandler: ^(NSArray<SWGWithdraw>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGWithdrawApi->withdrawInfoAll: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **NSString***| Currency 코드  | [optional] 
 **state** | **NSString***| 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  | [optional] 
 **uuids** | [**NSArray&lt;NSString*&gt;***](NSString*.md)| 출금 UUID의 목록  | [optional] 
 **txids** | [**NSArray&lt;NSString*&gt;***](NSString*.md)| 출금 TXID의 목록  | [optional] 
 **limit** | **NSNumber***| 개수 제한 (default: 100, max: 100)  | [optional] 
 **page** | **NSNumber***| 페이지 수, default: 1  | [optional] 
 **orderBy** | **NSString***| 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  | [optional] 

### Return type

[**NSArray<SWGWithdraw>***](SWGWithdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **withdrawKrw**
```objc
-(NSURLSessionTask*) withdrawKrwWithAmount: (NSString*) amount
        completionHandler: (void (^)(SWGWithdraw* output, NSError* error)) handler;
```

원화 출금하기

## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];


NSString* amount = @"amount_example"; // 출금 원화 수량 

SWGWithdrawApi*apiInstance = [[SWGWithdrawApi alloc] init];

// 원화 출금하기
[apiInstance withdrawKrwWithAmount:amount
          completionHandler: ^(SWGWithdraw* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGWithdrawApi->withdrawKrw: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amount** | **NSString***| 출금 원화 수량  | 

### Return type

[**SWGWithdraw***](SWGWithdraw.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

