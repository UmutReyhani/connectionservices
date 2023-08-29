using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("operations")]
public class OperationsController : ControllerBase
{
    private readonly ITransientOperation _firstTransientOperation;
    private readonly ITransientOperation _secondTransientOperation;

    private readonly IScopedOperation _firstScopedOperation;
    private readonly IScopedOperation _secondScopedOperation;

    public OperationsController(
        ITransientOperation firstTransientOperation,
        ITransientOperation secondTransientOperation,
        IScopedOperation firstScopedOperation,
        IScopedOperation secondScopedOperation)
    {
        _firstTransientOperation = firstTransientOperation;
        _secondTransientOperation = secondTransientOperation;

        _firstScopedOperation = firstScopedOperation;
        _secondScopedOperation = secondScopedOperation;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            FirstTransientId = _firstTransientOperation.GetOperationId(),
            SecondTransientId = _secondTransientOperation.GetOperationId(),
            FirstScopedId = _firstScopedOperation.GetOperationId(),
            SecondScopedId = _secondScopedOperation.GetOperationId()
        });
    }
}