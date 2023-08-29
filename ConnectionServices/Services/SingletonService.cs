public interface ISingletonService
{
    Guid GetOperationId();
}

public class SingletonService : ISingletonService
{
    private readonly Guid _id;

    public SingletonService()
    {
        _id = Guid.NewGuid();
    }

    public Guid GetOperationId() => _id;
}
