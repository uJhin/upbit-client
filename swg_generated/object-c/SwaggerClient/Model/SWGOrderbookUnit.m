#import "SWGOrderbookUnit.h"

@implementation SWGOrderbookUnit

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"askPrice": @"ask_price", @"bidPrice": @"bid_price", @"askSize": @"ask_size", @"bidSize": @"bid_size" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"askPrice", @"bidPrice", @"askSize", @"bidSize"];
  return [optionalProperties containsObject:propertyName];
}

@end
