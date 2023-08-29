using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly ITransientService _transientService;
    private readonly IScopedService _scopedService;
    private readonly ISingletonService _singletonService;

    public HomeController(ITransientService transientService, IScopedService scopedService, ISingletonService singletonService)
    {
        _transientService = transientService;
        _scopedService = scopedService;
        _singletonService = singletonService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            TransientId = _transientService.GetOperationId(),
            ScopedId = _scopedService.GetOperationId(),
            SingletonId = _singletonService.GetOperationId()
        });
    }
}
