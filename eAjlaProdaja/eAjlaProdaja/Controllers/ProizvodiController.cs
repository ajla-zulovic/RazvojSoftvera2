using eAjlaProdaja.Model;
using eAjlaProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eAjlaProdaja.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProizvodiController : ControllerBase
  {

    private readonly IProizvodiService _proizvodiService;
      private readonly ILogger<WeatherForecastController> _logger;

    public ProizvodiController(ILogger<WeatherForecastController> logger, IProizvodiService proizvodiService)
    {
      _logger = logger;
      _proizvodiService = proizvodiService;
    }

    [HttpGet()]
    public IEnumerable<Proizvodi> Get()
    {
      return _proizvodiService.Get();
    }
  }
}
