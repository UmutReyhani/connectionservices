public interface IScopedService
{
    Guid GetOperationId();
}

public class ScopedService : IScopedService
{
    private readonly Guid _id;

    public ScopedService()
    {
        _id = Guid.NewGuid();
    }

    public Guid GetOperationId() => _id;
}
