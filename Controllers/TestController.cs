using Microsoft.AspNetCore.Mvc;

namespace Access.Control.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> logger;
    public TestController(ILogger<TestController> logger)
    {
       this.logger = logger;
    }

    [HttpPost]
    public int Post([FromQuery] string userid)
    {
      if(userid is not null)
      {
         logger.LogInformation(userid);
        return 1;
      }
        
      return 0;
    }
}
