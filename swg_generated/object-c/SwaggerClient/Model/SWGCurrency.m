#import "SWGCurrency.h"

@implementation SWGCurrency

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"code": @"code", @"withdrawFee": @"withdraw_fee", @"isCoin": @"is_coin", @"walletState": @"wallet_state", @"walletSupport": @"wallet_support" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"code", @"withdrawFee", @"isCoin", @"walletState", @"walletSupport"];
  return [optionalProperties containsObject:propertyName];
}

@end
