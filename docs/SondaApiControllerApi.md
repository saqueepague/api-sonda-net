# IO.Swagger.Api.SondaApiControllerApi

All URIs are relative to *https://localhost/saqueepague-sonda/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SondaPost**](SondaApiControllerApi.md#sondapost) | **POST** /sonda | Retorna o estado de uma transação.


<a name="sondapost"></a>
# **SondaPost**
> SondaResp SondaPost (SondaReq sondaReq)

Retorna o estado de uma transação.

Procura o último estado conhecido de uma transação específica dos últimos 7 dias (casos que a sonda pode tentar verificar em finais de semana ou feriado).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SondaPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SondaApiControllerApi();
            var sondaReq = new SondaReq(); // SondaReq | Objeto com dados de procura da transação.

            try
            {
                // Retorna o estado de uma transação.
                SondaResp result = apiInstance.SondaPost(sondaReq);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SondaApiControllerApi.SondaPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sondaReq** | [**SondaReq**](SondaReq.md)| Objeto com dados de procura da transação. | 

### Return type

[**SondaResp**](SondaResp.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

