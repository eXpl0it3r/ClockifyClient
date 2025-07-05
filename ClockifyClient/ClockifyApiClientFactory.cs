using Microsoft.Kiota.Http.HttpClientLibrary;

namespace ClockifyClient;

public static class ClockifyApiClientFactory
{
    public static ClockifyApiClient Create(string apiKey, string baseUrl = "https://api.clockify.me/api")
    {
        var authProvider = new ApiKeyAuthenticationProvider(apiKey);
        var adapter = new HttpClientRequestAdapter(authProvider)
        {
            BaseUrl = baseUrl
        };
        return new ClockifyApiClient(adapter);
    }
}