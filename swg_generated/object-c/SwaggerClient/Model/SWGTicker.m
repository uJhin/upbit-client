#import "SWGTicker.h"

@implementation SWGTicker

- (instancetype)init {
  self = [super init];
  if (self) {
    // initialize property's default value, if any
    
  }
  return self;
}


/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper {
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"market": @"market", @"tradeDate": @"trade_date", @"tradeTime": @"trade_time", @"tradeDateKst": @"trade_date_kst", @"tradeTimeKst": @"trade_time_kst", @"openingPrice": @"opening_price", @"highPrice": @"high_price", @"lowPrice": @"low_price", @"tradePrice": @"trade_price", @"prevClosingPrice": @"prev_closing_price", @"change": @"change", @"changePrice": @"change_price", @"changeRate": @"change_rate", @"signedChangePrice": @"signed_change_price", @"signedChangeRate": @"signed_change_rate", @"tradeVolume": @"trade_volume", @"accTradePrice": @"acc_trade_price", @"accTradePrice24h": @"acc_trade_price_24h", @"accTradeVolume": @"acc_trade_volume", @"accTradeVolume24h": @"acc_trade_volume_24h", @"highest52WeekPrice": @"highest_52_week_price", @"highest52WeekDate": @"highest_52_week_date", @"lowest52WeekPrice": @"lowest_52_week_price", @"lowest52WeekDate": @"lowest_52_week_date", @"timestamp": @"timestamp" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"market", @"tradeDate", @"tradeTime", @"tradeDateKst", @"tradeTimeKst", @"openingPrice", @"highPrice", @"lowPrice", @"tradePrice", @"prevClosingPrice", @"change", @"changePrice", @"changeRate", @"signedChangePrice", @"signedChangeRate", @"tradeVolume", @"accTradePrice", @"accTradePrice24h", @"accTradeVolume", @"accTradeVolume24h", @"highest52WeekPrice", @"highest52WeekDate", @"lowest52WeekPrice", @"lowest52WeekDate", @"timestamp"];
  return [optionalProperties containsObject:propertyName];
}

@end
