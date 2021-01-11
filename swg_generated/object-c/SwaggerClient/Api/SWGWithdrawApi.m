#import "SWGWithdrawApi.h"
#import "SWGQueryParamCollection.h"
#import "SWGApiClient.h"
#import "SWGError.h"
#import "SWGWithdraw.h"
#import "SWGWithdrawChance.h"
#import "SWGWithdrawCoin.h"


@interface SWGWithdrawApi ()

@property (nonatomic, strong, readwrite) NSMutableDictionary *mutableDefaultHeaders;

@end

@implementation SWGWithdrawApi

NSString* kSWGWithdrawApiErrorDomain = @"SWGWithdrawApiErrorDomain";
NSInteger kSWGWithdrawApiMissingParamErrorCode = 234513;

@synthesize apiClient = _apiClient;

#pragma mark - Initialize methods

- (instancetype) init {
    return [self initWithApiClient:[SWGApiClient sharedClient]];
}


-(instancetype) initWithApiClient:(SWGApiClient *)apiClient {
    self = [super init];
    if (self) {
        _apiClient = apiClient;
        _mutableDefaultHeaders = [NSMutableDictionary dictionary];
    }
    return self;
}

#pragma mark -

-(NSString*) defaultHeaderForKey:(NSString*)key {
    return self.mutableDefaultHeaders[key];
}

-(void) setDefaultHeaderValue:(NSString*) value forKey:(NSString*)key {
    [self.mutableDefaultHeaders setValue:value forKey:key];
}

-(NSDictionary *)defaultHeaders {
    return self.mutableDefaultHeaders;
}

#pragma mark - Api Methods

///
/// 출금 가능 정보
/// ## 해당 통화의 가능한 출금 정보를 확인한다. 
///  @param currency Currency Symbol  
///
///  @returns SWGWithdrawChance*
///
-(NSURLSessionTask*) withdrawChanceWithCurrency: (NSString*) currency
    completionHandler: (void (^)(SWGWithdrawChance* output, NSError* error)) handler {
    // verify the required parameter 'currency' is set
    if (currency == nil) {
        NSParameterAssert(currency);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"currency"] };
            NSError* error = [NSError errorWithDomain:kSWGWithdrawApiErrorDomain code:kSWGWithdrawApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/withdraws/chance"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (currency != nil) {
        queryParams[@"currency"] = currency;
    }
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[@"application/json"]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[@"Bearer"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SWGWithdrawChance*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((SWGWithdrawChance*)data, error);
                                }
                            }];
}

///
/// 코인 출금하기
/// ## 코인 출금을 요청한다.  **NOTE**: 바로출금 이용 시 유의사항  업비트 회원의 주소가 아닌 주소로 바로출금을 요청하는 경우, 출금이 정상적으로 수행되지 않습니다. 반드시 주소를 확인 후 출금을 진행하시기 바랍니다. 
///  @param currency Currency 코드  
///
///  @param amount 출금 수량  
///
///  @param address 출금 가능 주소에 등록된 출금 주소  
///
///  @param secondaryAddress 2차 출금 주소 (필요한 코인에 한해서)  (optional)
///
///  @param transactionType 출금 유형 - default : 일반출금 - internal : 바로출금  (optional)
///
///  @returns SWGWithdrawCoin*
///
-(NSURLSessionTask*) withdrawCoinWithCurrency: (NSString*) currency
    amount: (NSString*) amount
    address: (NSString*) address
    secondaryAddress: (NSString*) secondaryAddress
    transactionType: (NSString*) transactionType
    completionHandler: (void (^)(SWGWithdrawCoin* output, NSError* error)) handler {
    // verify the required parameter 'currency' is set
    if (currency == nil) {
        NSParameterAssert(currency);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"currency"] };
            NSError* error = [NSError errorWithDomain:kSWGWithdrawApiErrorDomain code:kSWGWithdrawApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    // verify the required parameter 'amount' is set
    if (amount == nil) {
        NSParameterAssert(amount);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"amount"] };
            NSError* error = [NSError errorWithDomain:kSWGWithdrawApiErrorDomain code:kSWGWithdrawApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    // verify the required parameter 'address' is set
    if (address == nil) {
        NSParameterAssert(address);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"address"] };
            NSError* error = [NSError errorWithDomain:kSWGWithdrawApiErrorDomain code:kSWGWithdrawApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/withdraws/coin"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[@"application/json"]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[@"multipart/form-data"]];

    // Authentication setting
    NSArray *authSettings = @[@"Bearer"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    if (currency) {
        formParams[@"currency"] = currency;
    }
    if (amount) {
        formParams[@"amount"] = amount;
    }
    if (address) {
        formParams[@"address"] = address;
    }
    if (secondaryAddress) {
        formParams[@"secondary_address"] = secondaryAddress;
    }
    if (transactionType) {
        formParams[@"transaction_type"] = transactionType;
    }

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"POST"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SWGWithdrawCoin*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((SWGWithdrawCoin*)data, error);
                                }
                            }];
}

///
/// 개별 출금 조회
/// ## 출금 UUID를 통해 개별 출금 정보를 조회한다. 
///  @param uuid 출금 UUID  (optional)
///
///  @param txid 출금 TXID  (optional)
///
///  @param currency Currency 코드  (optional)
///
///  @returns SWGWithdraw*
///
-(NSURLSessionTask*) withdrawInfoWithUuid: (NSString*) uuid
    txid: (NSString*) txid
    currency: (NSString*) currency
    completionHandler: (void (^)(SWGWithdraw* output, NSError* error)) handler {
    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/withdraw"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (uuid != nil) {
        queryParams[@"uuid"] = uuid;
    }
    if (txid != nil) {
        queryParams[@"txid"] = txid;
    }
    if (currency != nil) {
        queryParams[@"currency"] = currency;
    }
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[@"application/json"]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[@"Bearer"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SWGWithdraw*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((SWGWithdraw*)data, error);
                                }
                            }];
}

///
/// 출금 리스트 조회
/// ## 출금 리스트를 조회한다. 
///  @param currency Currency 코드  (optional)
///
///  @param state 출금 상태 - submitting : 처리 중 - submitted : 처리 완료 - almost_accepted : 출금대기중 - rejected : 거부 - accepted : 승인됨 - processing : 처리 중 - done : 완료 - canceled : 취소됨  (optional)
///
///  @param uuids 출금 UUID의 목록  (optional)
///
///  @param txids 출금 TXID의 목록  (optional)
///
///  @param limit 개수 제한 (default: 100, max: 100)  (optional)
///
///  @param page 페이지 수, default: 1  (optional)
///
///  @param orderBy 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  (optional)
///
///  @returns NSArray<SWGWithdraw>*
///
-(NSURLSessionTask*) withdrawInfoAllWithCurrency: (NSString*) currency
    state: (NSString*) state
    uuids: (NSArray<NSString*>*) uuids
    txids: (NSArray<NSString*>*) txids
    limit: (NSNumber*) limit
    page: (NSNumber*) page
    orderBy: (NSString*) orderBy
    completionHandler: (void (^)(NSArray<SWGWithdraw>* output, NSError* error)) handler {
    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/withdraws"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (currency != nil) {
        queryParams[@"currency"] = currency;
    }
    if (state != nil) {
        queryParams[@"state"] = state;
    }
    if (uuids != nil) {
        queryParams[@"uuids"] = [[SWGQueryParamCollection alloc] initWithValuesAndFormat: uuids format: @"multi"];
    }
    if (txids != nil) {
        queryParams[@"txids"] = [[SWGQueryParamCollection alloc] initWithValuesAndFormat: txids format: @"multi"];
    }
    if (limit != nil) {
        queryParams[@"limit"] = limit;
    }
    if (page != nil) {
        queryParams[@"page"] = page;
    }
    if (orderBy != nil) {
        queryParams[@"order_by"] = orderBy;
    }
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[@"application/json"]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[]];

    // Authentication setting
    NSArray *authSettings = @[@"Bearer"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"GET"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"NSArray<SWGWithdraw>*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSArray<SWGWithdraw>*)data, error);
                                }
                            }];
}

///
/// 원화 출금하기
/// ## 원화 출금을 요청한다. 등록된 출금 계좌로 출금된다. 
///  @param amount 출금 원화 수량  
///
///  @returns SWGWithdraw*
///
-(NSURLSessionTask*) withdrawKrwWithAmount: (NSString*) amount
    completionHandler: (void (^)(SWGWithdraw* output, NSError* error)) handler {
    // verify the required parameter 'amount' is set
    if (amount == nil) {
        NSParameterAssert(amount);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"amount"] };
            NSError* error = [NSError errorWithDomain:kSWGWithdrawApiErrorDomain code:kSWGWithdrawApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/withdraws/krw"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[@"application/json"]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[@"multipart/form-data"]];

    // Authentication setting
    NSArray *authSettings = @[@"Bearer"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    if (amount) {
        formParams[@"amount"] = amount;
    }

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"POST"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SWGWithdraw*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((SWGWithdraw*)data, error);
                                }
                            }];
}



@end
