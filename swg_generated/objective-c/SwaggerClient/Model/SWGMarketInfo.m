#import "SWGMarketInfo.h"

@implementation SWGMarketInfo

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"market": @"market", @"koreanName": @"korean_name", @"englishName": @"english_name", @"marketWarning": @"market_warning" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"market", @"koreanName", @"englishName", @"marketWarning"];
  return [optionalProperties containsObject:propertyName];
}

@end
