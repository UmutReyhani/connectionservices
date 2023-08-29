public interface ITransientService
{
    Guid GetOperationId();
}

public class TransientService : ITransientService
{
    private readonly Guid _id;

    public TransientService()
    {
        _id = Guid.NewGuid();
    }

    public Guid GetOperationId() => _id;
}
