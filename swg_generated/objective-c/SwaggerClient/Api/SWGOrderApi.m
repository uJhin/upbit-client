#import "SWGOrderApi.h"
#import "SWGQueryParamCollection.h"
#import "SWGApiClient.h"
#import "SWGError.h"
#import "SWGNewOrder.h"
#import "SWGOrder.h"
#import "SWGOrderChance.h"
#import "SWGOrderInfo.h"
#import "SWGOrderbook.h"


@interface SWGOrderApi ()

@property (nonatomic, strong, readwrite) NSMutableDictionary *mutableDefaultHeaders;

@end

@implementation SWGOrderApi

NSString* kSWGOrderApiErrorDomain = @"SWGOrderApiErrorDomain";
NSInteger kSWGOrderApiMissingParamErrorCode = 234513;

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
/// 주문 취소 접수
/// ## 주문 UUID를 통해 해당 주문에 대한 취소 접수를 한다. **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 
///  @param uuid 취소할 주문의 UUID  (optional)
///
///  @param identifier 조회용 사용자 지정 값  (optional)
///
///  @returns SWGOrder*
///
-(NSURLSessionTask*) orderCancelWithUuid: (NSString*) uuid
    identifier: (NSString*) identifier
    completionHandler: (void (^)(SWGOrder* output, NSError* error)) handler {
    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/order"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (uuid != nil) {
        queryParams[@"uuid"] = uuid;
    }
    if (identifier != nil) {
        queryParams[@"identifier"] = identifier;
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
                                    method: @"DELETE"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"SWGOrder*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((SWGOrder*)data, error);
                                }
                            }];
}

///
/// 주문 가능 정보
/// ## 마켓별 주문 가능 정보를 확인한다. 
///  @param market Market ID  
///
///  @returns SWGOrderChance*
///
-(NSURLSessionTask*) orderChanceWithMarket: (NSString*) market
    completionHandler: (void (^)(SWGOrderChance* output, NSError* error)) handler {
    // verify the required parameter 'market' is set
    if (market == nil) {
        NSParameterAssert(market);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"market"] };
            NSError* error = [NSError errorWithDomain:kSWGOrderApiErrorDomain code:kSWGOrderApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/orders/chance"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (market != nil) {
        queryParams[@"market"] = market;
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
                              responseType: @"SWGOrderChance*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((SWGOrderChance*)data, error);
                                }
                            }];
}

///
/// 개별 주문 조회
/// ## 주문 UUID를 통해 개별 주문건을 조회한다. **NOTE**: `uuid` 혹은 `identifier` 둘 중 하나의 값이 반드시 포함되어야 합니다. 
///  @param uuid 주문 UUID  (optional)
///
///  @param identifier 조회용 사용자 지정 값  (optional)
///
///  @returns SWGOrderInfo*
///
-(NSURLSessionTask*) orderInfoWithUuid: (NSString*) uuid
    identifier: (NSString*) identifier
    completionHandler: (void (^)(SWGOrderInfo* output, NSError* error)) handler {
    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/order"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (uuid != nil) {
        queryParams[@"uuid"] = uuid;
    }
    if (identifier != nil) {
        queryParams[@"identifier"] = identifier;
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
                              responseType: @"SWGOrderInfo*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((SWGOrderInfo*)data, error);
                                }
                            }];
}

///
/// 주문 리스트 조회
/// ## 주문 리스트를 조회한다. 
///  @param market 마켓 아이디  (optional)
///
///  @param state 주문 상태   - wait : 체결 대기 (default)   - done : 전체 체결 완료   - cancel : 주문 취소  (optional)
///
///  @param states 주문 상태의 목록  (optional)
///
///  @param uuids 주문 UUID의 목록  (optional)
///
///  @param identifiers 주문 identifier의 목록  (optional)
///
///  @param page 페이지 수, default: 1  (optional)
///
///  @param limit 요청 개수, default: 100  (optional)
///
///  @param orderBy 정렬 방식 - asc : 오름차순 - desc : 내림차순 (default)  (optional)
///
///  @returns NSArray<SWGOrder>*
///
-(NSURLSessionTask*) orderInfoAllWithMarket: (NSString*) market
    state: (NSString*) state
    states: (NSArray<NSString*>*) states
    uuids: (NSArray<NSString*>*) uuids
    identifiers: (NSArray<NSString*>*) identifiers
    page: (NSNumber*) page
    limit: (NSNumber*) limit
    orderBy: (NSString*) orderBy
    completionHandler: (void (^)(NSArray<SWGOrder>* output, NSError* error)) handler {
    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/orders"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (market != nil) {
        queryParams[@"market"] = market;
    }
    if (state != nil) {
        queryParams[@"state"] = state;
    }
    if (states != nil) {
        queryParams[@"states"] = [[SWGQueryParamCollection alloc] initWithValuesAndFormat: states format: @"multi"];
    }
    if (uuids != nil) {
        queryParams[@"uuids"] = [[SWGQueryParamCollection alloc] initWithValuesAndFormat: uuids format: @"multi"];
    }
    if (identifiers != nil) {
        queryParams[@"identifiers"] = [[SWGQueryParamCollection alloc] initWithValuesAndFormat: identifiers format: @"multi"];
    }
    if (page != nil) {
        queryParams[@"page"] = page;
    }
    if (limit != nil) {
        queryParams[@"limit"] = limit;
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
                              responseType: @"NSArray<SWGOrder>*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSArray<SWGOrder>*)data, error);
                                }
                            }];
}

///
/// 주문하기
/// ## 주문 요청을 한다. **NOTE**: 원화 마켓 가격 단위를 확인하세요. 원화 마켓에서 주문을 요청 할 경우, [원화 마켓 주문 가격 단위](https://docs.upbit.com/docs/market-info-trade-price-detail)를 확인하여 값을 입력해주세요. **NOTE**: identifier 파라미터 사용 `identifier`는 서비스에서 발급하는 `uuid`가 아닌 이용자가 직접 발급하는 키값으로, 주문을 조회하기 위해 할당하는 값입니다. 해당 값은 사용자의 전체 주문 내 유일한 값을 전달해야하며, 비록 주문 요청시 오류가 발생하더라도 같은 값으로 다시 요청을 보낼 수 없습니다. 주문의 성공 / 실패 여부와 관계없이 중복해서 들어온 `identifier` 값에서는 중복 오류가 발생하니, 매 요청시 새로운 값을 생성해주세요. **NOTE**: 시장가 주문 시장가 주문은 `ord_type` 필드를 `price` or `market` 으로 설정해야됩니다. 매수 주문의 경우 `ord_type`을 `price`로 설정하고 `volume`을 `null` 혹은 제외해야됩니다. 매도 주문의 경우 `ord_type`을 `market`로 설정하고 `price`을 `null` 혹은 제외해야됩니다. 
///  @param market 마켓 ID (필수)  
///
///  @param side 주문 종류 (필수) - bid : 매수 - ask : 매도  
///
///  @param ordType 주문 타입 (필수) - limit : 지정가 주문 - price : 시장가 주문(매수) - market : 시장가 주문(매도)  
///
///  @param volume 주문량 (지정가, 시장가 매도 시 필수)  (optional, default to null)
///
///  @param price 주문 가격. (지정가, 시장가 매수 시 필수) ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다. ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우, 시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다. (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)  (optional, default to null)
///
///  @param identifier 조회용 사용자 지정값 (선택)  (optional)
///
///  @returns SWGNewOrder*
///
-(NSURLSessionTask*) orderNewWithMarket: (NSString*) market
    side: (NSString*) side
    ordType: (NSString*) ordType
    volume: (NSString*) volume
    price: (NSString*) price
    identifier: (NSString*) identifier
    completionHandler: (void (^)(SWGNewOrder* output, NSError* error)) handler {
    // verify the required parameter 'market' is set
    if (market == nil) {
        NSParameterAssert(market);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"market"] };
            NSError* error = [NSError errorWithDomain:kSWGOrderApiErrorDomain code:kSWGOrderApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    // verify the required parameter 'side' is set
    if (side == nil) {
        NSParameterAssert(side);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"side"] };
            NSError* error = [NSError errorWithDomain:kSWGOrderApiErrorDomain code:kSWGOrderApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    // verify the required parameter 'ordType' is set
    if (ordType == nil) {
        NSParameterAssert(ordType);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"ordType"] };
            NSError* error = [NSError errorWithDomain:kSWGOrderApiErrorDomain code:kSWGOrderApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/orders"];

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
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[@"application/x-www-form-urlencoded", @"multipart/form-data", @"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"Bearer"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    if (market) {
        formParams[@"market"] = market;
    }
    if (side) {
        formParams[@"side"] = side;
    }
    if (volume) {
        formParams[@"volume"] = volume;
    }
    if (price) {
        formParams[@"price"] = price;
    }
    if (ordType) {
        formParams[@"ord_type"] = ordType;
    }
    if (identifier) {
        formParams[@"identifier"] = identifier;
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
                              responseType: @"SWGNewOrder*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((SWGNewOrder*)data, error);
                                }
                            }];
}

///
/// 시세 호가 정보(Orderbook) 조회
/// ## 호가 정보 조회 
///  @param markets 마켓 코드 목록 (ex. KRW-BTC,KRW-ADA)  
///
///  @returns NSArray<SWGOrderbook>*
///
-(NSURLSessionTask*) orderOrderbookWithMarkets: (NSArray<NSString*>*) markets
    completionHandler: (void (^)(NSArray<SWGOrderbook>* output, NSError* error)) handler {
    // verify the required parameter 'markets' is set
    if (markets == nil) {
        NSParameterAssert(markets);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"markets"] };
            NSError* error = [NSError errorWithDomain:kSWGOrderApiErrorDomain code:kSWGOrderApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/orderbook"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (markets != nil) {
        queryParams[@"markets"] = [[SWGQueryParamCollection alloc] initWithValuesAndFormat: markets format: @"multi"];
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
                              responseType: @"NSArray<SWGOrderbook>*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSArray<SWGOrderbook>*)data, error);
                                }
                            }];
}



@end
