using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using backend.Dtos;

namespace backend.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CalculatorController : ControllerBase
  {
    [HttpPost("feeds-and-speeds")]
    public IActionResult CalculateFeedsAndSpeeds([FromBody] FeedsAndSpeedsRequest request)
    {
      // Prevent division by zero
      if (request.ToolDiameter <= 0 || request.Flutes <= 0 || request.ChipLoad <= 0)
      {
        return BadRequest("Invalid input values");
      }

      // RPM Formula
      double rpm = (request.SFM * 3.82) / request.ToolDiameter;

      // Feedrate Formula
      double feedRate = rpm * request.Flutes * request.ChipLoad;

      return Ok(new
      {
        RPM = Math.Round(rpm, 2),
        FeedRate = Math.Round(feedRate, 2)
      });
    }
  }
}