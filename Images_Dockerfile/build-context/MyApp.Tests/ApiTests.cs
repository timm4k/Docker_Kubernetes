using Microsoft.AspNetCore.Mvc.Testing;
using System.Text.Json;
using Xunit;

namespace MyApp.Tests;

public class ApiTests
{
    [Fact]
    public async Task RootReturnsApplicationStatus()
    {
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();
        using var response = await client.GetAsync("/");

        response.EnsureSuccessStatusCode();
        Assert.Equal("application/json", response.Content.Headers.ContentType?.MediaType);
        using var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        Assert.Equal("MyApp.Api", document.RootElement.GetProperty("application").GetString());
        Assert.Equal("running", document.RootElement.GetProperty("status").GetString());
    }
}
