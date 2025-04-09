# XperiencesAI.SDK.Model.AgentResponse
Response schema for agent operations. Extends the base Agent schema with additional response-specific fields.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the agent | 
**Id** | **string** | Unique identifier for the agent | 
**Status** | **AgentStatus** | Current status of the agent | 
**VarConfiguration** | **Dictionary&lt;string, Object&gt;** | Additional configuration for the agent | 
**CreatedAt** | **DateTime** | Creation timestamp | 
**UpdatedAt** | **DateTime** | Last update timestamp | 
**Description** | **string** |  | [optional] 
**AssistantId** | **string** |  | [optional] 
**PromptTemplate** | **string** |  | [optional] 
**ErrorMessage** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

