#import "SWGOrderInfo.h"

@implementation SWGOrderInfo

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"uuid": @"uuid", @"side": @"side", @"ordType": @"ord_type", @"price": @"price", @"state": @"state", @"market": @"market", @"createdAt": @"created_at", @"volume": @"volume", @"remainingVolume": @"remaining_volume", @"reservedFee": @"reserved_fee", @"remainingFee": @"remaining_fee", @"paidFee": @"paid_fee", @"locked": @"locked", @"executedVolume": @"executed_volume", @"tradesCount": @"trades_count", @"trades": @"trades" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"uuid", @"side", @"ordType", @"price", @"state", @"market", @"createdAt", @"volume", @"remainingVolume", @"reservedFee", @"remainingFee", @"paidFee", @"locked", @"executedVolume", @"tradesCount", @"trades"];
  return [optionalProperties containsObject:propertyName];
}

@end
