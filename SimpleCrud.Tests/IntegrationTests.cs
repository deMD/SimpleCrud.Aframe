using FluentAssertions;

namespace SimpleCrud.Tests;

public sealed class IntegrationTests : IClassFixture<SimpleCrudApplicationFactory>
{
    private readonly SimpleCrudApplicationFactory _webApplicationFactory;

    public IntegrationTests(SimpleCrudApplicationFactory webApplicationFactory)
    {
        _webApplicationFactory = webApplicationFactory;
    }

    [Fact]
    public async Task Create()
    {
        var client = _webApplicationFactory.CreateClient();
        var response = await client.PostAsync("crud", null);

        response.Should().BeSuccessful();
    }
}