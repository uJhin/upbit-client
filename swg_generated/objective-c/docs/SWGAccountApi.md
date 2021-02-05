# SWGAccountApi

All URIs are relative to *https://api.upbit.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accountInfo**](SWGAccountApi.md#accountinfo) | **GET** /accounts | 전체 계좌 조회
[**accountWallet**](SWGAccountApi.md#accountwallet) | **GET** /status/wallet | 입출금 현황


# **accountInfo**
```objc
-(NSURLSessionTask*) accountInfoWithCompletionHandler: 
        (void (^)(NSArray<SWGAccount>* output, NSError* error)) handler;
```

전체 계좌 조회

## 내가 보유한 자산 리스트를 보여줍니다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];



SWGAccountApi*apiInstance = [[SWGAccountApi alloc] init];

// 전체 계좌 조회
[apiInstance accountInfoWithCompletionHandler: 
          ^(NSArray<SWGAccount>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGAccountApi->accountInfo: %@", error);
                        }
                    }];
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**NSArray<SWGAccount>***](SWGAccount.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountWallet**
```objc
-(NSURLSessionTask*) accountWalletWithCompletionHandler: 
        (void (^)(NSArray<SWGWallet>* output, NSError* error)) handler;
```

입출금 현황

## 입출금 현황 및 블록 상태를 조회합니다.  **NOTE**: 입출금 현황 데이터는 실제 서비스 상태와 다를 수 있습니다.  입출금 현황 API에서 제공하는 입출금 상태, 블록 상태 정보는 수 분 정도 지연되어 반영될 수 있습니다. 본 API는 참고용으로만 사용하시길 바라며 실제 입출금을 수행하기 전에는 반드시 업비트 공지사항 및 입출금 현황 페이지를 참고해주시기 바랍니다. 

### Example 
```objc
SWGDefaultConfiguration *apiConfig = [SWGDefaultConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: Bearer)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"Authorization"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"Authorization"];



SWGAccountApi*apiInstance = [[SWGAccountApi alloc] init];

// 입출금 현황
[apiInstance accountWalletWithCompletionHandler: 
          ^(NSArray<SWGWallet>* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGAccountApi->accountWallet: %@", error);
                        }
                    }];
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**NSArray<SWGWallet>***](SWGWallet.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

