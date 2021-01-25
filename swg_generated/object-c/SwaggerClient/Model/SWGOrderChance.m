#import "SWGOrderChance.h"

@implementation SWGOrderChance

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"bidFee": @"bid_fee", @"askFee": @"ask_fee", @"market": @"market", @"bidAccount": @"bid_account", @"askAccount": @"ask_account" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"bidFee", @"askFee", @"market", @"bidAccount", @"askAccount"];
  return [optionalProperties containsObject:propertyName];
}

@end
