namespace SimpleCrud.Tests;

[UsesVerify]
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
        HttpClient client = _webApplicationFactory.CreateClient();
        HttpResponseMessage response = await client.PostAsync("crud", null);

        response.Should().BeSuccessful();
        var content = await response.Content.ReadAsStringAsync();
        await Verify(content);
    }
}