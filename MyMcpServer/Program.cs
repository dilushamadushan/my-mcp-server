using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Reflection;

var builder = Host.CreateApplicationBuilder(args);

// Configure console logging to capture all levels
builder.Logging.AddConsole(options =>
{
    options.LogToStandardErrorThreshold = LogLevel.Trace;
});

// Add and configure the MCP server
builder.Services.AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly(Assembly.GetExecutingAssembly()); // Register all tools from this assembly

// Display the content root path for reference
Console.WriteLine("Content Root Path: " + builder.Environment.ContentRootPath);

// Build and run the host
var app = builder.Build();
await app.RunAsync();


// ---------------- MCP Tools ---------------- //

[McpServerToolType]
public static class HelloTool
{
    [McpServerTool(Name = "MyMcpServer"), Description("Welcome to the MCP Server!")]
    public static void SayHello()
    {
        Console.WriteLine("Hello from the MCP Server!");
    }

    [McpServerTool(Name = "Echo"), Description("Echo back the provided message.")]
    public static void Echo(string message)
    {
        Console.WriteLine($"You said: {message}");
    }

    [McpServerTool(Name = "Greet"), Description("Greets a user by name.")]
    public static void Greet(string name)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");

            Console.WriteLine($"Hello, {name}!");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"[Greet Error] {ex.Message}");
        }
    }
}
