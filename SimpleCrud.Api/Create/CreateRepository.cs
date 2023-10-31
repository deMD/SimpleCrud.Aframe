namespace SimpleCrud.Api.Create;

public class CreateRepository
{
    public static CreateRepository CreateNull()
    {
        return new CreateRepository();
    }

    public ToDoItem Get(int id)
    {
        return new ToDoItem(id, "todo item");
    }
}