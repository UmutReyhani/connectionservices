public interface IScopedOperation
{
    Guid GetOperationId();
}

public class ScopedOperation : IScopedOperation
{
    private readonly Guid _id;

    public ScopedOperation()
    {
        _id = Guid.NewGuid();
    }

    public Guid GetOperationId() => _id;
}