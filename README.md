# Clockify Client

This project provides a strongly-typed C# client for interacting with the [Clockify](https://app.clockify.me/) time tracking API.
The client is automatically generated from Clockify's OpenAPI specification using [Microsoft Kiota](https://github.com/microsoft/kiota), ensuring type safety and up-to-date API coverage.

## Prerequisites

- .NET Standard 2.0 / .NET 8.0 or later
- Clockify API key ([Get your API key](https://app.clockify.me/manage-api-keys))

## Installation

Get the `ClockifyClient` package from [NuGet](https://www.nuget.org/packages/ClockifyClient):

```bash
dotnet add package ClockifyClient
```

## Usage

```csharp
using ClockifyClient;

// Initialize the client with your API key
var client = ClockifyApiClientFactory.Create("your-api-key-here");

// Get user information
var user = await client.User.GetAsync();
Console.WriteLine($"Hello, {user.Name}!");

// Get workspaces
var workspaces = await client.Workspaces.GetAsync();
foreach (var workspace in workspaces)
{
    Console.WriteLine($"Workspace: {workspace.Name}");
}

// Get active times for the active workspace
var timeEntries = await client.V1.Workspaces[user.ActiveWorkspace].TimeEntries.Status.InProgress.GetAsync();
```

## Error Handling

The client provides structured error handling:

```csharp
try
{
    var user = await client.User.GetAsync();
}
catch (ApiException ex)
{
    Console.WriteLine($"API Error: {ex.ResponseStatusCode} - {ex.Message}");
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"Network Error: {ex.Message}");
}
```

## Development

### Generating the Client

The client is generated using Microsoft Kiota. To regenerate the client:

```bash
# Install Kiota CLI
dotnet tool install --global Microsoft.OpenApi.Kiota

# Download the latest OpenAPI specification
curl -o clockify-openapi.json https://docs.clockify.me/openapi.json

# Apply modifications, see below

# Generate the client from OpenAPI spec
kiota generate --language CSharp --openapi clockify-openapi.json --class-name ClockifyApiClient --namespace-name ClockifyClient --output ClockifyClient --structured-mime-types application/json
```

### Modifications

The OpenAPI specification provided by Clockify doesn't work out of the box with Kiota and requires some modifications.

#### Fixing Enum Types

Replace the following part of the specification

```json
"adminOnlyPages": { "type": "string", "description": "Represents a unique list of protected page enums.", "example": "[\"PROJECT\",\"TEAM\",\"REPORTS\"]", "enum": ["PROJECT", "TEAM", "REPORTS"] },
```

with this part instead

```json
"adminOnlyPages": { 
    "type": "array", 
    "description": "Represents a unique list of protected page enums.", 
    "items": {
        "type": "string",
        "enum": ["PROJECT", "TEAM", "REPORTS"]
    },
    "example": "[\"PROJECT\", \"TEAM\", \"REPORTS\"]"
},
```

#### Fixing Media Types

Replace occurrences of `*/*` with `application/json`.
Except for the file / export endpoints that use `byte` as `format`, namely:

- `/v1/workspaces/{workspaceId}/expenses/{expenseId}/files/{fileId}`
- `/v1/workspaces/{workspaceId}/invoices/{invoiceId}/export`

For example, like this:

```json
"responses": { "200": { "content": { "*/*": { "schema": { "$ref": "#/components/schemas/TimeEntrySummaryReportDto" } } }, "description": "OK" } },
```

```json
"responses": { "200": { "content": { "application/json": { "schema": { "$ref": "#/components/schemas/TimeEntrySummaryReportDto" } } }, "description": "OK" } },
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
