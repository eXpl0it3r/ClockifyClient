using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;

namespace ClockifyClient;

public class ApiKeyAuthenticationProvider : IAuthenticationProvider
{
    private readonly string _apiKey;

    public ApiKeyAuthenticationProvider(string apiKey)
    {
        _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
    }

    public Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
    {
        request.Headers.Add("X-Api-Key", _apiKey);
        return Task.CompletedTask;
    }
}