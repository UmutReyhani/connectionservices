public interface ITransientOperation
{
    Guid GetOperationId();
}

public class TransientOperation : ITransientOperation
{
    private readonly Guid _id;

    public TransientOperation()
    {
        _id = Guid.NewGuid();
    }

    public Guid GetOperationId() => _id;
}