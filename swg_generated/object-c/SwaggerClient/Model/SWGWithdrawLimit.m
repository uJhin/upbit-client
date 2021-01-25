#import "SWGWithdrawLimit.h"

@implementation SWGWithdrawLimit

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"currency": @"currency", @"minimum": @"minimum", @"onetime": @"onetime", @"daily": @"daily", @"remainingDaily": @"remaining_daily", @"remainingDailyKrw": @"remaining_daily_krw", @"fixed": @"fixed", @"canWithdraw": @"can_withdraw" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"currency", @"minimum", @"onetime", @"daily", @"remainingDaily", @"remainingDailyKrw", @"fixed", @"canWithdraw"];
  return [optionalProperties containsObject:propertyName];
}

@end
