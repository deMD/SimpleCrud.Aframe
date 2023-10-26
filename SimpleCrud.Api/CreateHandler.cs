using MinimalApi.Endpoint;

namespace SimpleCrud.Api;

public class CreateHandler : IEndpoint<IResult>
{
    public async Task<IResult> HandleAsync()
    {
        return await Task.FromResult(Results.Ok(1));
    }

    public void AddRoute(IEndpointRouteBuilder app)
    {
        app.MapPost("crud", HandleAsync);
    }
}