using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace Tool1;
public class ToolOne
{
    public string? ipAddress;
    public static async Task GetIp()
    {
        try
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync("http://checkip.dyndns.org/");
            int index = response.IndexOf("Current IP Address:");
            string ipAddress = response.Substring(index + 20, response.IndexOf("</body>") - index - 20);
            Console.WriteLine($"Your IP address is: {ipAddress}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error getting IP address: {0}", ex.Message);
        }
    }
}
