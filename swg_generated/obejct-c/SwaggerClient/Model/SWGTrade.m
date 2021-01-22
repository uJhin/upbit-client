#import "SWGTrade.h"

@implementation SWGTrade

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"market": @"market", @"uuid": @"uuid", @"price": @"price", @"volume": @"volume", @"funds": @"funds", @"side": @"side", @"createdAt": @"created_at" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"market", @"uuid", @"price", @"volume", @"funds", @"side", @"createdAt"];
  return [optionalProperties containsObject:propertyName];
}

@end
