namespace SimpleCrud.Api;

public class CreateHandler
{
    public async Task<IResult> Handle()
    {
        return await Task.FromResult(Results.Ok(1));
    }
}