# XperiencesAI.SDK.Api.UsersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateUserApiV1UsersPost**](UsersApi.md#createuserapiv1userspost) | **POST** /api/v1/users | Create User |
| [**DeleteUserApiV1UsersUserIdDelete**](UsersApi.md#deleteuserapiv1usersuseriddelete) | **DELETE** /api/v1/users/{user_id} | Delete User |
| [**GetUserApiV1UsersUserIdGet**](UsersApi.md#getuserapiv1usersuseridget) | **GET** /api/v1/users/{user_id} | Get User |
| [**UpdateUserApiV1UsersUserIdPut**](UsersApi.md#updateuserapiv1usersuseridput) | **PUT** /api/v1/users/{user_id} | Update User |

<a id="createuserapiv1userspost"></a>
# **CreateUserApiV1UsersPost**
> UserResponse CreateUserApiV1UsersPost (UserCreate userCreate)

Create User

Create a new user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class CreateUserApiV1UsersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UsersApi(config);
            var userCreate = new UserCreate(); // UserCreate | 

            try
            {
                // Create User
                UserResponse result = apiInstance.CreateUserApiV1UsersPost(userCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUserApiV1UsersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUserApiV1UsersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create User
    ApiResponse<UserResponse> response = apiInstance.CreateUserApiV1UsersPostWithHttpInfo(userCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.CreateUserApiV1UsersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userCreate** | [**UserCreate**](UserCreate.md) |  |  |

### Return type

[**UserResponse**](UserResponse.md)

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

<a id="deleteuserapiv1usersuseriddelete"></a>
# **DeleteUserApiV1UsersUserIdDelete**
> void DeleteUserApiV1UsersUserIdDelete (string userId)

Delete User

Delete a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class DeleteUserApiV1UsersUserIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | 

            try
            {
                // Delete User
                apiInstance.DeleteUserApiV1UsersUserIdDelete(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserApiV1UsersUserIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserApiV1UsersUserIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete User
    apiInstance.DeleteUserApiV1UsersUserIdDeleteWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.DeleteUserApiV1UsersUserIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |

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

<a id="getuserapiv1usersuseridget"></a>
# **GetUserApiV1UsersUserIdGet**
> UserResponse GetUserApiV1UsersUserIdGet (string userId)

Get User

Get a user by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class GetUserApiV1UsersUserIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | 

            try
            {
                // Get User
                UserResponse result = apiInstance.GetUserApiV1UsersUserIdGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserApiV1UsersUserIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserApiV1UsersUserIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User
    ApiResponse<UserResponse> response = apiInstance.GetUserApiV1UsersUserIdGetWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserApiV1UsersUserIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |

### Return type

[**UserResponse**](UserResponse.md)

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

<a id="updateuserapiv1usersuseridput"></a>
# **UpdateUserApiV1UsersUserIdPut**
> UserResponse UpdateUserApiV1UsersUserIdPut (string userId, UserUpdate userUpdate)

Update User

Update a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class UpdateUserApiV1UsersUserIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | 
            var userUpdate = new UserUpdate(); // UserUpdate | 

            try
            {
                // Update User
                UserResponse result = apiInstance.UpdateUserApiV1UsersUserIdPut(userId, userUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserApiV1UsersUserIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserApiV1UsersUserIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update User
    ApiResponse<UserResponse> response = apiInstance.UpdateUserApiV1UsersUserIdPutWithHttpInfo(userId, userUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpdateUserApiV1UsersUserIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **userUpdate** | [**UserUpdate**](UserUpdate.md) |  |  |

### Return type

[**UserResponse**](UserResponse.md)

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

