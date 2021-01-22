#import "SWGAskAccount.h"

@implementation SWGAskAccount

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"currency": @"currency", @"balance": @"balance", @"locked": @"locked", @"avgBuyPrice": @"avg_buy_price", @"avgBuyPriceModified": @"avg_buy_price_modified", @"unitCurrency": @"unit_currency" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"currency", @"balance", @"locked", @"avgBuyPrice", @"avgBuyPriceModified", @"unitCurrency"];
  return [optionalProperties containsObject:propertyName];
}

@end
