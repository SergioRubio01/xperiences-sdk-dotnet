# XperiencesAI.SDK.Api.HealthApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DatabaseHealthCheckHealthDatabaseGet**](HealthApi.md#databasehealthcheckhealthdatabaseget) | **GET** /health/database | Database Health Check |
| [**HealthCheckHealthGet**](HealthApi.md#healthcheckhealthget) | **GET** /health | Health Check |

<a id="databasehealthcheckhealthdatabaseget"></a>
# **DatabaseHealthCheckHealthDatabaseGet**
> Dictionary&lt;string, string&gt; DatabaseHealthCheckHealthDatabaseGet ()

Database Health Check

Database health check endpoint.  Args:     db: Database session (injected via DbSession alias)  Returns:     Database connection status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class DatabaseHealthCheckHealthDatabaseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new HealthApi(config);

            try
            {
                // Database Health Check
                Dictionary<string, string> result = apiInstance.DatabaseHealthCheckHealthDatabaseGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HealthApi.DatabaseHealthCheckHealthDatabaseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatabaseHealthCheckHealthDatabaseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Database Health Check
    ApiResponse<Dictionary<string, string>> response = apiInstance.DatabaseHealthCheckHealthDatabaseGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HealthApi.DatabaseHealthCheckHealthDatabaseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Dictionary<string, string>**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="healthcheckhealthget"></a>
# **HealthCheckHealthGet**
> Dictionary&lt;string, string&gt; HealthCheckHealthGet ()

Health Check

Health check endpoint.  Returns:     Health status and API version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using XperiencesAI.SDK.Api;
using XperiencesAI.SDK.Client;
using XperiencesAI.SDK.Model;

namespace Example
{
    public class HealthCheckHealthGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new HealthApi(config);

            try
            {
                // Health Check
                Dictionary<string, string> result = apiInstance.HealthCheckHealthGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HealthApi.HealthCheckHealthGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HealthCheckHealthGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Health Check
    ApiResponse<Dictionary<string, string>> response = apiInstance.HealthCheckHealthGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HealthApi.HealthCheckHealthGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Dictionary<string, string>**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

