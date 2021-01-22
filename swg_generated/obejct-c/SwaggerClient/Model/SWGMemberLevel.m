#import "SWGMemberLevel.h"

@implementation SWGMemberLevel

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"securityLevel": @"security_level", @"feeLevel": @"fee_level", @"emailVerified": @"email_verified", @"identityAuthVerified": @"identity_auth_verified", @"bankAccountVerified": @"bank_account_verified", @"kakaoPayAuthVerified": @"kakao_pay_auth_verified", @"locked": @"locked", @"walletLocked": @"wallet_locked" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"securityLevel", @"feeLevel", @"emailVerified", @"identityAuthVerified", @"bankAccountVerified", @"kakaoPayAuthVerified", @"locked", @"walletLocked"];
  return [optionalProperties containsObject:propertyName];
}

@end
