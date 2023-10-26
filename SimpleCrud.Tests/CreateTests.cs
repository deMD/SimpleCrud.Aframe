using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using SimpleCrud.Api;

namespace SimpleCrud.Tests;

public class CreateTests
{
    [Fact]
    public async Task ReturnsId()
    {
        var handler = new CreateHandler();
        var response = await handler.HandleAsync();
        var okResponse = (Ok<int>)response;
        okResponse.StatusCode.Should().Be(StatusCodes.Status200OK);
        okResponse.Value.Should().Be(1);
    }
}