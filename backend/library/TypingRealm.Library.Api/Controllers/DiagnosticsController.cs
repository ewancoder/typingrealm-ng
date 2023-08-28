using System;
using Microsoft.AspNetCore.Mvc;

namespace TypingRealm.Library.Api.Controllers;

[Route("diag")]
public sealed class DiagnosticsController : ControllerBase
{
    [HttpGet]
    [Route("now")]
    public ActionResult Now()
    {
        return Ok(new
        {
            Now = DateTime.UtcNow
        });
    }
}
