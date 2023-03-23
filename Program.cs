global using Spectre.Console;
global using SharpPcap;
global using System.Net;
global using Tool1;

namespace Networking;
public class Program
{
    public static async Task Main(string[] args)
    {
        await MainAsync();
    }
    public static async Task MainAsync()
    {
        var choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Select a tool")
            .PageSize(20)
            .AddChoices(new[] { "1", "2", "3", "4", }));
        switch (choice)
        {
            case "1":
            await Tool1.ToolOne.GetIp();
            break;

            case "2":
                break;

            case "3":
                break;

            case "4":
                break;
        }
    }
}