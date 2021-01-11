# SWGWallet

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**currency** | **NSString*** | 화폐를 의미하는 영문 대문자 코드 | [optional] 
**walletState** | **NSString*** | 입출금 상태 - working : 입출금 가능 - withdraw_only : 출금만 가능 - deposit_only : 입금만 가능 - paused : 입출금 중단 - unsupported : 입출금 미지원  | [optional] 
**blockState** | **NSString*** | 블록 상태 - normal : 정상 - delayed : 지연 - inactive : 비활성 (점검 등)  | [optional] 
**blockHeight** | **NSNumber*** | 블록 높이 | [optional] 
**blockUpdatedAt** | **NSString*** | 블록 갱신 시각 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


