#import "SWGDeposit.h"

@implementation SWGDeposit

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"type": @"type", @"uuid": @"uuid", @"currency": @"currency", @"txid": @"txid", @"state": @"state", @"createdAt": @"created_at", @"doneAt": @"done_at", @"amount": @"amount", @"fee": @"fee", @"transactionType": @"transaction_type" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"type", @"uuid", @"currency", @"txid", @"state", @"createdAt", @"doneAt", @"amount", @"fee", @"transactionType"];
  return [optionalProperties containsObject:propertyName];
}

@end
