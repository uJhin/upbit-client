#import "SWGCandleApi.h"
#import "SWGQueryParamCollection.h"
#import "SWGApiClient.h"
#import "SWGError.h"


@interface SWGCandleApi ()

@property (nonatomic, strong, readwrite) NSMutableDictionary *mutableDefaultHeaders;

@end

@implementation SWGCandleApi

NSString* kSWGCandleApiErrorDomain = @"SWGCandleApiErrorDomain";
NSInteger kSWGCandleApiMissingParamErrorCode = 234513;

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
/// 시세 캔들 조회 (일 단위)
/// ## 일(Day) 캔들 
///  @param market 마켓 코드 (ex. KRW-BTC)  
///
///  @param to 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
///
///  @param count 캔들 개수  (optional)
///
///  @param convertingPriceUnit 종가 환산 화폐 단위 (생략 가능, KRW로 명시할 시 원화 환산 가격을 반환.)  `convertingPriceUnit` 파라미터의 경우, 원화 마켓이 아닌 다른 마켓(ex. BTC, ETH)의 일봉 요청 시 종가를 명시된 파라미터 값으로 환산해 `converted_trade_price` 필드에 추가하여 반환합니다. 현재는 원화(`KRW`) 로 변환하는 기능만 제공하며 추후 기능을 확장할 수 있습니다.  (optional, default to KRW)
///
///  @returns NSObject*
///
-(NSURLSessionTask*) candleDaysWithMarket: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
    convertingPriceUnit: (NSString*) convertingPriceUnit
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler {
    // verify the required parameter 'market' is set
    if (market == nil) {
        NSParameterAssert(market);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"market"] };
            NSError* error = [NSError errorWithDomain:kSWGCandleApiErrorDomain code:kSWGCandleApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/candles/days"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (market != nil) {
        queryParams[@"market"] = market;
    }
    if (to != nil) {
        queryParams[@"to"] = to;
    }
    if (count != nil) {
        queryParams[@"count"] = count;
    }
    if (convertingPriceUnit != nil) {
        queryParams[@"convertingPriceUnit"] = convertingPriceUnit;
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
                              responseType: @"NSObject*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSObject*)data, error);
                                }
                            }];
}

///
/// 시세 캔들 조회 (분 단위)
/// ## 분(Minute) 캔들 
///  @param unit 분 단위. 가능한 값 : 1, 3, 5, 15, 10, 30, 60, 240  
///
///  @param market 마켓 코드 (ex. KRW-BTC)  
///
///  @param to 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
///
///  @param count 캔들 개수 (최대 200개까지 요청 가능)  (optional)
///
///  @returns NSObject*
///
-(NSURLSessionTask*) candleMinutesWithUnit: (NSNumber*) unit
    market: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler {
    // verify the required parameter 'unit' is set
    if (unit == nil) {
        NSParameterAssert(unit);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"unit"] };
            NSError* error = [NSError errorWithDomain:kSWGCandleApiErrorDomain code:kSWGCandleApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    // verify the required parameter 'market' is set
    if (market == nil) {
        NSParameterAssert(market);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"market"] };
            NSError* error = [NSError errorWithDomain:kSWGCandleApiErrorDomain code:kSWGCandleApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/candles/minutes/{unit}"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (unit != nil) {
        pathParams[@"unit"] = unit;
    }

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (market != nil) {
        queryParams[@"market"] = market;
    }
    if (to != nil) {
        queryParams[@"to"] = to;
    }
    if (count != nil) {
        queryParams[@"count"] = count;
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
                              responseType: @"NSObject*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSObject*)data, error);
                                }
                            }];
}

///
/// 시세 캔들 조회 (월 단위)
/// ## 월(Month) 캔들 
///  @param market 마켓 코드 (ex. KRW-BTC)  
///
///  @param to 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
///
///  @param count 캔들 개수  (optional)
///
///  @returns NSObject*
///
-(NSURLSessionTask*) candleMonthWithMarket: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler {
    // verify the required parameter 'market' is set
    if (market == nil) {
        NSParameterAssert(market);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"market"] };
            NSError* error = [NSError errorWithDomain:kSWGCandleApiErrorDomain code:kSWGCandleApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/candles/months"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (market != nil) {
        queryParams[@"market"] = market;
    }
    if (to != nil) {
        queryParams[@"to"] = to;
    }
    if (count != nil) {
        queryParams[@"count"] = count;
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
                              responseType: @"NSObject*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSObject*)data, error);
                                }
                            }];
}

///
/// 시세 캔들 조회 (주 단위)
/// ## 주(Week) 캔들 
///  @param market 마켓 코드 (ex. KRW-BTC)  
///
///  @param to 마지막 캔들 시각 (exclusive). 포맷 : `yyyy-MM-dd'T'HH:mm:ssXXX` or `yyyy-MM-dd HH:mm:ss`. 비워서 요청 시 가장 최근 캔들  (optional)
///
///  @param count 캔들 개수  (optional)
///
///  @returns NSObject*
///
-(NSURLSessionTask*) candleWeeksWithMarket: (NSString*) market
    to: (NSString*) to
    count: (NSNumber*) count
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler {
    // verify the required parameter 'market' is set
    if (market == nil) {
        NSParameterAssert(market);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"market"] };
            NSError* error = [NSError errorWithDomain:kSWGCandleApiErrorDomain code:kSWGCandleApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/candles/weeks"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if (market != nil) {
        queryParams[@"market"] = market;
    }
    if (to != nil) {
        queryParams[@"to"] = to;
    }
    if (count != nil) {
        queryParams[@"count"] = count;
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
                              responseType: @"NSObject*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((NSObject*)data, error);
                                }
                            }];
}



@end
