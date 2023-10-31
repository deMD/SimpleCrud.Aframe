using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using SimpleCrud.Api.Create;

namespace SimpleCrud.Tests;

public class CreateTests
{
    private static readonly CreateRequest DefaultCreateRequest = new("todo item");

    [Fact]
    public async Task ReturnsId()
    {
        var handler = new CreateHandler(CreateRepository.CreateNull());
        IResult response = await handler.HandleAsync(DefaultCreateRequest);
        
        var okResponse = (Ok<int>)response;
        okResponse.StatusCode.Should().Be(StatusCodes.Status200OK);
        okResponse.Value.Should().Be(1);
    }

    [Theory]
    [InlineData("todo item")]
    [InlineData("another todo item")]
    public async Task SaveValidRequest(string text)
    {
        var repository = CreateRepository.CreateNull();

        var request = new CreateRequest(text);
        
        var handler = new CreateHandler(repository);
        IResult response = await handler.HandleAsync(request);
        var okResponse = (Ok<int>)response;
        
        repository.Get(okResponse.Value).Text.Should().Be(request.Text);
    }
}