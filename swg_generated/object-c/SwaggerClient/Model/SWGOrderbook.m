#import "SWGOrderbook.h"

@implementation SWGOrderbook

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"market": @"market", @"timestamp": @"timestamp", @"totalAskSize": @"total_ask_size", @"totalBidSize": @"total_bid_size", @"orderbookUnits": @"orderbook_units" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"market", @"timestamp", @"totalAskSize", @"totalBidSize", @"orderbookUnits"];
  return [optionalProperties containsObject:propertyName];
}

@end
