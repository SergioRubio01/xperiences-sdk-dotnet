# XperiencesAI.SDK.Api.AgentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAgentApiV1AgentsPost**](AgentsApi.md#createagentapiv1agentspost) | **POST** /api/v1/agents/ | Create Agent |
| [**CreateConversationApiV1AgentsAgentIdConversationsPost**](AgentsApi.md#createconversationapiv1agentsagentidconversationspost) | **POST** /api/v1/agents/{agent_id}/conversations | Create Conversation |
| [**DeleteAgentApiV1AgentsAgentIdDelete**](AgentsApi.md#deleteagentapiv1agentsagentiddelete) | **DELETE** /api/v1/agents/{agent_id} | Delete Agent |
| [**GetAgentApiV1AgentsAgentIdGet**](AgentsApi.md#getagentapiv1agentsagentidget) | **GET** /api/v1/agents/{agent_id} | Get Agent |
| [**GetConversationApiV1AgentsAgentIdConversationsConversationIdGet**](AgentsApi.md#getconversationapiv1agentsagentidconversationsconversationidget) | **GET** /api/v1/agents/{agent_id}/conversations/{conversation_id} | Get Conversation |
| [**ListAgentsApiV1AgentsGet**](AgentsApi.md#listagentsapiv1agentsget) | **GET** /api/v1/agents/ | List Agents |
| [**ListConversationsApiV1AgentsAgentIdConversationsGet**](AgentsApi.md#listconversationsapiv1agentsagentidconversationsget) | **GET** /api/v1/agents/{agent_id}/conversations | List Conversations |
| [**ListMessagesApiV1AgentsAgentIdConversationsConversationIdMessagesGet**](AgentsApi.md#listmessagesapiv1agentsagentidconversationsconversationidmessagesget) | **GET** /api/v1/agents/{agent_id}/conversations/{conversation_id}/messages | List Messages |
| [**ProcessSpeechApiV1AgentsAgentIdSpeechPost**](AgentsApi.md#processspeechapiv1agentsagentidspeechpost) | **POST** /api/v1/agents/{agent_id}/speech | Process Speech |
| [**ProcessTextApiV1AgentsAgentIdTextPost**](AgentsApi.md#processtextapiv1agentsagentidtextpost) | **POST** /api/v1/agents/{agent_id}/text | Process Text |
| [**UpdateAgentApiV1AgentsAgentIdPut**](AgentsApi.md#updateagentapiv1agentsagentidput) | **PUT** /api/v1/agents/{agent_id} | Update Agent |

<a id="createagentapiv1agentspost"></a>
# **CreateAgentApiV1AgentsPost**
> AgentResponse CreateAgentApiV1AgentsPost (AgentCreate agentCreate)

Create Agent

Create a new agent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class CreateAgentApiV1AgentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);
            var agentCreate = new AgentCreate(); // AgentCreate | 

            try
            {
                // Create Agent
                AgentResponse result = apiInstance.CreateAgentApiV1AgentsPost(agentCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.CreateAgentApiV1AgentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAgentApiV1AgentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Agent
    ApiResponse<AgentResponse> response = apiInstance.CreateAgentApiV1AgentsPostWithHttpInfo(agentCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.CreateAgentApiV1AgentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentCreate** | [**AgentCreate**](AgentCreate.md) |  |  |

### Return type

[**AgentResponse**](AgentResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createconversationapiv1agentsagentidconversationspost"></a>
# **CreateConversationApiV1AgentsAgentIdConversationsPost**
> Conversation CreateConversationApiV1AgentsAgentIdConversationsPost (string agentId, ConversationCreate conversationCreate)

Create Conversation

Create a new conversation for an agent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class CreateConversationApiV1AgentsAgentIdConversationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);
            var agentId = "agentId_example";  // string | 
            var conversationCreate = new ConversationCreate(); // ConversationCreate | 

            try
            {
                // Create Conversation
                Conversation result = apiInstance.CreateConversationApiV1AgentsAgentIdConversationsPost(agentId, conversationCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.CreateConversationApiV1AgentsAgentIdConversationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateConversationApiV1AgentsAgentIdConversationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Conversation
    ApiResponse<Conversation> response = apiInstance.CreateConversationApiV1AgentsAgentIdConversationsPostWithHttpInfo(agentId, conversationCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.CreateConversationApiV1AgentsAgentIdConversationsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentId** | **string** |  |  |
| **conversationCreate** | [**ConversationCreate**](ConversationCreate.md) |  |  |

### Return type

[**Conversation**](Conversation.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteagentapiv1agentsagentiddelete"></a>
# **DeleteAgentApiV1AgentsAgentIdDelete**
> void DeleteAgentApiV1AgentsAgentIdDelete (string agentId)

Delete Agent

Delete an agent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class DeleteAgentApiV1AgentsAgentIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);
            var agentId = "agentId_example";  // string | 

            try
            {
                // Delete Agent
                apiInstance.DeleteAgentApiV1AgentsAgentIdDelete(agentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.DeleteAgentApiV1AgentsAgentIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAgentApiV1AgentsAgentIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Agent
    apiInstance.DeleteAgentApiV1AgentsAgentIdDeleteWithHttpInfo(agentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.DeleteAgentApiV1AgentsAgentIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getagentapiv1agentsagentidget"></a>
# **GetAgentApiV1AgentsAgentIdGet**
> AgentResponse GetAgentApiV1AgentsAgentIdGet (string agentId)

Get Agent

Get an agent by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class GetAgentApiV1AgentsAgentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);
            var agentId = "agentId_example";  // string | 

            try
            {
                // Get Agent
                AgentResponse result = apiInstance.GetAgentApiV1AgentsAgentIdGet(agentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.GetAgentApiV1AgentsAgentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAgentApiV1AgentsAgentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Agent
    ApiResponse<AgentResponse> response = apiInstance.GetAgentApiV1AgentsAgentIdGetWithHttpInfo(agentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.GetAgentApiV1AgentsAgentIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentId** | **string** |  |  |

### Return type

[**AgentResponse**](AgentResponse.md)

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

<a id="getconversationapiv1agentsagentidconversationsconversationidget"></a>
# **GetConversationApiV1AgentsAgentIdConversationsConversationIdGet**
> Conversation GetConversationApiV1AgentsAgentIdConversationsConversationIdGet (string agentId, string conversationId)

Get Conversation

Get conversation details by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class GetConversationApiV1AgentsAgentIdConversationsConversationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);
            var agentId = "agentId_example";  // string | 
            var conversationId = "conversationId_example";  // string | 

            try
            {
                // Get Conversation
                Conversation result = apiInstance.GetConversationApiV1AgentsAgentIdConversationsConversationIdGet(agentId, conversationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.GetConversationApiV1AgentsAgentIdConversationsConversationIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConversationApiV1AgentsAgentIdConversationsConversationIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Conversation
    ApiResponse<Conversation> response = apiInstance.GetConversationApiV1AgentsAgentIdConversationsConversationIdGetWithHttpInfo(agentId, conversationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.GetConversationApiV1AgentsAgentIdConversationsConversationIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentId** | **string** |  |  |
| **conversationId** | **string** |  |  |

### Return type

[**Conversation**](Conversation.md)

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

<a id="listagentsapiv1agentsget"></a>
# **ListAgentsApiV1AgentsGet**
> List&lt;Agent&gt; ListAgentsApiV1AgentsGet (int skip = null, int limit = null)

List Agents

List all available agents.  Args:     agent_service: Injected AgentService instance     auth: Authentication dependency     skip: Number of agents to skip     limit: Maximum number of agents to return  Returns:     List of agents

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class ListAgentsApiV1AgentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);
            var skip = 0;  // int | Number of agents to skip (optional)  (default to 0)
            var limit = 100;  // int | Max number of agents (optional)  (default to 100)

            try
            {
                // List Agents
                List<Agent> result = apiInstance.ListAgentsApiV1AgentsGet(skip, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.ListAgentsApiV1AgentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAgentsApiV1AgentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Agents
    ApiResponse<List<Agent>> response = apiInstance.ListAgentsApiV1AgentsGetWithHttpInfo(skip, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.ListAgentsApiV1AgentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **skip** | **int** | Number of agents to skip | [optional] [default to 0] |
| **limit** | **int** | Max number of agents | [optional] [default to 100] |

### Return type

[**List&lt;Agent&gt;**](Agent.md)

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

<a id="listconversationsapiv1agentsagentidconversationsget"></a>
# **ListConversationsApiV1AgentsAgentIdConversationsGet**
> List&lt;Conversation&gt; ListConversationsApiV1AgentsAgentIdConversationsGet (string agentId, int skip = null, int limit = null)

List Conversations

List all conversations for an agent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class ListConversationsApiV1AgentsAgentIdConversationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);
            var agentId = "agentId_example";  // string | 
            var skip = 0;  // int | Number of conversations to skip (optional)  (default to 0)
            var limit = 100;  // int | Max conversations (optional)  (default to 100)

            try
            {
                // List Conversations
                List<Conversation> result = apiInstance.ListConversationsApiV1AgentsAgentIdConversationsGet(agentId, skip, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.ListConversationsApiV1AgentsAgentIdConversationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConversationsApiV1AgentsAgentIdConversationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Conversations
    ApiResponse<List<Conversation>> response = apiInstance.ListConversationsApiV1AgentsAgentIdConversationsGetWithHttpInfo(agentId, skip, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.ListConversationsApiV1AgentsAgentIdConversationsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentId** | **string** |  |  |
| **skip** | **int** | Number of conversations to skip | [optional] [default to 0] |
| **limit** | **int** | Max conversations | [optional] [default to 100] |

### Return type

[**List&lt;Conversation&gt;**](Conversation.md)

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

<a id="listmessagesapiv1agentsagentidconversationsconversationidmessagesget"></a>
# **ListMessagesApiV1AgentsAgentIdConversationsConversationIdMessagesGet**
> List&lt;Message&gt; ListMessagesApiV1AgentsAgentIdConversationsConversationIdMessagesGet (string agentId, string conversationId, int skip = null, int limit = null)

List Messages

List all messages for a conversation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class ListMessagesApiV1AgentsAgentIdConversationsConversationIdMessagesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);
            var agentId = "agentId_example";  // string | 
            var conversationId = "conversationId_example";  // string | 
            var skip = 0;  // int | Number of messages to skip (optional)  (default to 0)
            var limit = 100;  // int | Max messages to return (optional)  (default to 100)

            try
            {
                // List Messages
                List<Message> result = apiInstance.ListMessagesApiV1AgentsAgentIdConversationsConversationIdMessagesGet(agentId, conversationId, skip, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.ListMessagesApiV1AgentsAgentIdConversationsConversationIdMessagesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMessagesApiV1AgentsAgentIdConversationsConversationIdMessagesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Messages
    ApiResponse<List<Message>> response = apiInstance.ListMessagesApiV1AgentsAgentIdConversationsConversationIdMessagesGetWithHttpInfo(agentId, conversationId, skip, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.ListMessagesApiV1AgentsAgentIdConversationsConversationIdMessagesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentId** | **string** |  |  |
| **conversationId** | **string** |  |  |
| **skip** | **int** | Number of messages to skip | [optional] [default to 0] |
| **limit** | **int** | Max messages to return | [optional] [default to 100] |

### Return type

[**List&lt;Message&gt;**](Message.md)

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

<a id="processspeechapiv1agentsagentidspeechpost"></a>
# **ProcessSpeechApiV1AgentsAgentIdSpeechPost**
> MessageResponse ProcessSpeechApiV1AgentsAgentIdSpeechPost (string agentId, System.IO.Stream audioFile)

Process Speech

Process speech input and return response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class ProcessSpeechApiV1AgentsAgentIdSpeechPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);
            var agentId = "agentId_example";  // string | 
            var audioFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Process Speech
                MessageResponse result = apiInstance.ProcessSpeechApiV1AgentsAgentIdSpeechPost(agentId, audioFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.ProcessSpeechApiV1AgentsAgentIdSpeechPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProcessSpeechApiV1AgentsAgentIdSpeechPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Process Speech
    ApiResponse<MessageResponse> response = apiInstance.ProcessSpeechApiV1AgentsAgentIdSpeechPostWithHttpInfo(agentId, audioFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.ProcessSpeechApiV1AgentsAgentIdSpeechPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentId** | **string** |  |  |
| **audioFile** | **System.IO.Stream****System.IO.Stream** |  |  |

### Return type

[**MessageResponse**](MessageResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="processtextapiv1agentsagentidtextpost"></a>
# **ProcessTextApiV1AgentsAgentIdTextPost**
> TextResponse ProcessTextApiV1AgentsAgentIdTextPost (string agentId, TextRequest textRequest)

Process Text

Process text input for an agent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class ProcessTextApiV1AgentsAgentIdTextPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);
            var agentId = "agentId_example";  // string | 
            var textRequest = new TextRequest(); // TextRequest | 

            try
            {
                // Process Text
                TextResponse result = apiInstance.ProcessTextApiV1AgentsAgentIdTextPost(agentId, textRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.ProcessTextApiV1AgentsAgentIdTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProcessTextApiV1AgentsAgentIdTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Process Text
    ApiResponse<TextResponse> response = apiInstance.ProcessTextApiV1AgentsAgentIdTextPostWithHttpInfo(agentId, textRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.ProcessTextApiV1AgentsAgentIdTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentId** | **string** |  |  |
| **textRequest** | [**TextRequest**](TextRequest.md) |  |  |

### Return type

[**TextResponse**](TextResponse.md)

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

<a id="updateagentapiv1agentsagentidput"></a>
# **UpdateAgentApiV1AgentsAgentIdPut**
> Agent UpdateAgentApiV1AgentsAgentIdPut (string agentId, AgentUpdate agentUpdate)

Update Agent

Update an agent.  Args:     agent_id: Agent ID     agent_update: Agent update data     agent_service: Injected AgentService instance     agent: Current agent model from dependency     auth: Authentication dependency  Returns:     Updated agent

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class UpdateAgentApiV1AgentsAgentIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentsApi(config);
            var agentId = "agentId_example";  // string | 
            var agentUpdate = new AgentUpdate(); // AgentUpdate | 

            try
            {
                // Update Agent
                Agent result = apiInstance.UpdateAgentApiV1AgentsAgentIdPut(agentId, agentUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.UpdateAgentApiV1AgentsAgentIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAgentApiV1AgentsAgentIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Agent
    ApiResponse<Agent> response = apiInstance.UpdateAgentApiV1AgentsAgentIdPutWithHttpInfo(agentId, agentUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.UpdateAgentApiV1AgentsAgentIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentId** | **string** |  |  |
| **agentUpdate** | [**AgentUpdate**](AgentUpdate.md) |  |  |

### Return type

[**Agent**](Agent.md)

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

