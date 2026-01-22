using System.Text;
using ClockifyClient;
using ConsoleAppFramework;

Console.OutputEncoding = Encoding.UTF8;

var app = ConsoleApp.Create();
app.Add<ClockifyCommands>();
await app.RunAsync(args);

public class ClockifyCommands
{
    /// <summary>
    ///     Fetch basic information from your Clockify account
    /// </summary>
    /// <param name="apikey">-k, Your Clockify API key. Get it from https://app.clockify.me/manage-api-keys</param>
    public async Task Info(string apikey)
    {
        if (string.IsNullOrEmpty(apikey))
        {
            Console.WriteLine("❌ API key is required. Use --apikey or -k to provide your Clockify API key.");
            Console.WriteLine("   Get your API key from: https://app.clockify.me/manage-api-keys");
            return;
        }

        try
        {
            Console.WriteLine("🚀 Initializing Clockify API client...");
            var client = ClockifyApiClientFactory.Create(apikey);

            await GetUserInfoAsync(client);
            await GetWorkspacesInfoAsync(client);
            await GetTimersInfoAsync(client);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error: {ex.Message}");
            if (ex.InnerException != null)
            {
                Console.WriteLine($"   Details: {ex.InnerException.Message}");
            }
        }
    }

    private static async Task GetUserInfoAsync(ClockifyApiClient client)
    {
        var user = await client.V1.User.GetAsync();

        if (user != null)
        {
            Console.WriteLine($"User: {user?.Name ?? "N/A"} ({user?.Email ?? "N/A"})");
        }
        else
        {
            Console.WriteLine("⚠️ API returned no user information");
        }
    }

    private static async Task GetWorkspacesInfoAsync(ClockifyApiClient client)
    {
        var workspaces = await client.V1.Workspaces.GetAsync();

        if (workspaces != null)
        {
            Console.WriteLine("Workspaces:");
            foreach (var workspace in workspaces)
            {
                Console.WriteLine($"- {workspace.Name} ({workspace.Id})");
            }
        }
        else
        {
            Console.WriteLine("⚠️ API returned no workspaces");
        }
    }

    private static async Task GetTimersInfoAsync(ClockifyApiClient client)
    {
        var user = await client.V1.User.GetAsync();

        if (user == null)
        {
            Console.WriteLine("⚠️ API returned no user information");
            return;
        }

        var timers = await client.V1.Workspaces[user.ActiveWorkspace].TimeEntries.Status.InProgress.GetAsync();

        if (timers != null)
        {
            Console.WriteLine("Timers:");

            if (timers.Count > 0)
            {
                var projects = await client.V1.Workspaces[user.ActiveWorkspace].Projects.GetAsync();
                
                foreach (var timer in timers)
                {
                    var projectName = string.Empty;

                    if (projects != null)
                    {
                        projectName = projects.FirstOrDefault(p => p.Id == timer.ProjectId)?.Name ?? string.Empty;
                        projectName = $"[{projectName}] ";
                    }

                    var description = string.IsNullOrEmpty(timer.Description) ? "N/A" : timer.Description;

                    Console.WriteLine($"  {projectName}{description} ({timer.Id})");
                }
            }
            else
            {
                Console.WriteLine("  No active timers found");
            }
        }
        else
        {
            Console.WriteLine("⚠️ API returned no timers");
        }
    }
}
