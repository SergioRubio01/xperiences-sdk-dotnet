# XperiencesAI.SDK.Api.ChatApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateChatApiV1ChatChatsPost**](ChatApi.md#createchatapiv1chatchatspost) | **POST** /api/v1/chat/chats | Create Chat |
| [**CreateMessageApiV1ChatChatsChatIdMessagesPost**](ChatApi.md#createmessageapiv1chatchatschatidmessagespost) | **POST** /api/v1/chat/chats/{chat_id}/messages | Create Message |
| [**GetChatApiV1ChatChatsChatIdGet**](ChatApi.md#getchatapiv1chatchatschatidget) | **GET** /api/v1/chat/chats/{chat_id} | Get Chat |

<a id="createchatapiv1chatchatspost"></a>
# **CreateChatApiV1ChatChatsPost**
> ConversationResponse CreateChatApiV1ChatChatsPost (ConversationCreate conversationCreate)

Create Chat

Create a new chat.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class CreateChatApiV1ChatChatsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatApi(config);
            var conversationCreate = new ConversationCreate(); // ConversationCreate | 

            try
            {
                // Create Chat
                ConversationResponse result = apiInstance.CreateChatApiV1ChatChatsPost(conversationCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatApi.CreateChatApiV1ChatChatsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateChatApiV1ChatChatsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Chat
    ApiResponse<ConversationResponse> response = apiInstance.CreateChatApiV1ChatChatsPostWithHttpInfo(conversationCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatApi.CreateChatApiV1ChatChatsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversationCreate** | [**ConversationCreate**](ConversationCreate.md) |  |  |

### Return type

[**ConversationResponse**](ConversationResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createmessageapiv1chatchatschatidmessagespost"></a>
# **CreateMessageApiV1ChatChatsChatIdMessagesPost**
> MessageResponse CreateMessageApiV1ChatChatsChatIdMessagesPost (string chatId, MessageCreate messageCreate)

Create Message

Create a new message in a chat.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class CreateMessageApiV1ChatChatsChatIdMessagesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatApi(config);
            var chatId = "chatId_example";  // string | 
            var messageCreate = new MessageCreate(); // MessageCreate | 

            try
            {
                // Create Message
                MessageResponse result = apiInstance.CreateMessageApiV1ChatChatsChatIdMessagesPost(chatId, messageCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatApi.CreateMessageApiV1ChatChatsChatIdMessagesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMessageApiV1ChatChatsChatIdMessagesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Message
    ApiResponse<MessageResponse> response = apiInstance.CreateMessageApiV1ChatChatsChatIdMessagesPostWithHttpInfo(chatId, messageCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatApi.CreateMessageApiV1ChatChatsChatIdMessagesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatId** | **string** |  |  |
| **messageCreate** | [**MessageCreate**](MessageCreate.md) |  |  |

### Return type

[**MessageResponse**](MessageResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchatapiv1chatchatschatidget"></a>
# **GetChatApiV1ChatChatsChatIdGet**
> ConversationResponse GetChatApiV1ChatChatsChatIdGet (string chatId)

Get Chat

Get a chat by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class GetChatApiV1ChatChatsChatIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChatApi(config);
            var chatId = "chatId_example";  // string | 

            try
            {
                // Get Chat
                ConversationResponse result = apiInstance.GetChatApiV1ChatChatsChatIdGet(chatId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatApiV1ChatChatsChatIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChatApiV1ChatChatsChatIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Chat
    ApiResponse<ConversationResponse> response = apiInstance.GetChatApiV1ChatChatsChatIdGetWithHttpInfo(chatId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChatApi.GetChatApiV1ChatChatsChatIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatId** | **string** |  |  |

### Return type

[**ConversationResponse**](ConversationResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

