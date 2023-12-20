using Department.Application.DTOs;
using Department.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Department.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISender _sender;


        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ISender sender)
        {
            _logger = logger;
            _sender = sender;
        }


        [HttpGet]
        public async Task<ActionResult<DepartmentWithEmployeeListDTO>> GetDepartment([FromQuery] GetDepartmentWithEmployeesQuery model)
            => await _sender.Send(model);
    }
}