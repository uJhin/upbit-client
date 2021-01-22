#import "SWGTradeTicks.h"

@implementation SWGTradeTicks

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"market": @"market", @"tradeDateUtc": @"trade_date_utc", @"tradeTimeUtc": @"trade_time_utc", @"timestamp": @"timestamp", @"tradePrice": @"trade_price", @"tradeVolume": @"trade_volume", @"prevClosingPrice": @"prev_closing_price", @"changePrice": @"change_price", @"askBid": @"ask_bid", @"sequentialId": @"sequential_id" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"market", @"tradeDateUtc", @"tradeTimeUtc", @"timestamp", @"tradePrice", @"tradeVolume", @"prevClosingPrice", @"changePrice", @"askBid", @"sequentialId"];
  return [optionalProperties containsObject:propertyName];
}

@end
