# IO.Swagger.Api.AuthControllerApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SaqueepagueOauthTokenPost**](AuthControllerApi.md#saqueepagueoauthtokenpost) | **POST** /saqueepague/oauth/token | Retorna o token de autenticação do serviço.


<a name="saqueepagueoauthtokenpost"></a>
# **SaqueepagueOauthTokenPost**
> AuthResp SaqueepagueOauthTokenPost (string grantType, string password, string username)

Retorna o token de autenticação do serviço.

Autentica o usuário e gera um token para a requisição de sonda.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaqueepagueOauthTokenPostExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthControllerApi();
            var grantType = grantType_example;  // string | Constante passada para este tipo de autenticação: password.
            var password = password_example;  // string | Senha disponibilizada pela SEP.
            var username = username_example;  // string | Usuário disponibilizado pela SEP.

            try
            {
                // Retorna o token de autenticação do serviço.
                AuthResp result = apiInstance.SaqueepagueOauthTokenPost(grantType, password, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthControllerApi.SaqueepagueOauthTokenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grantType** | **string**| Constante passada para este tipo de autenticação: password. | 
 **password** | **string**| Senha disponibilizada pela SEP. | 
 **username** | **string**| Usuário disponibilizado pela SEP. | 

### Return type

[**AuthResp**](AuthResp.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

