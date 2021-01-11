#import "SWGMarket.h"

@implementation SWGMarket

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"_id": @"id", @"name": @"name", @"orderTypes": @"order_types", @"orderSides": @"order_sides", @"bid": @"bid", @"ask": @"ask", @"maxTotal": @"max_total", @"state": @"state" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"_id", @"name", @"orderTypes", @"orderSides", @"bid", @"ask", @"maxTotal", @"state"];
  return [optionalProperties containsObject:propertyName];
}

@end
