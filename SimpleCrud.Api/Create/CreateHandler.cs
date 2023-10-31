using MinimalApi.Endpoint;

namespace SimpleCrud.Api.Create;

public class CreateHandler : IEndpoint<IResult, CreateRequest>
{
    private readonly CreateRepository _repository;

    public CreateHandler(CreateRepository repository)
    {
        _repository = repository;
    }

    public async Task<IResult> HandleAsync(CreateRequest createRequest)
    {
        return await Task.FromResult(Results.Ok(1));
    }

    public void AddRoute(IEndpointRouteBuilder app)
    {
        app.MapPost("crud", () => HandleAsync(new CreateRequest("todo item")));
    }
}