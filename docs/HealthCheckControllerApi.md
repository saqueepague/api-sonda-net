# IO.Swagger.Api.HealthCheckControllerApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActuatorHealthGet**](HealthCheckControllerApi.md#actuatorhealthget) | **GET** /actuator/health | Retorna o estado do serviço.


<a name="actuatorhealthget"></a>
# **ActuatorHealthGet**
> Dictionary<string, string> ActuatorHealthGet ()

Retorna o estado do serviço.

Verifica a disponibilidade do serviço de sonda.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActuatorHealthGetExample
    {
        public void main()
        {
            var apiInstance = new HealthCheckControllerApi();

            try
            {
                // Retorna o estado do serviço.
                Dictionary&lt;string, string&gt; result = apiInstance.ActuatorHealthGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthCheckControllerApi.ActuatorHealthGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

