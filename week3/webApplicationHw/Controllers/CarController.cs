using Microsoft.AspNetCore.Mvc;
using webApplicationHw.Models;
namespace webApplicationHw.Controllers;
[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{
    public static List<Car> Cars { get; set; } = new List<Car>(){
        new Car(){ ID=0, Brand="Fiat", Model="500", Year=2019},
        new Car(){ID=1, Brand="Volvo", Model="S90", Year=2022}
    };
    [HttpGet("GetAllCars")]
    public IEnumerable<Car> GetAllCars()
    {
        return Cars;
    }
    [HttpPost("AddCar")]
    public void AddCar([FromBody] Car car)
    {
        Cars.Add(car);
    }
    [HttpGet("ConvertionGlloontoLitter")]
    public double ConvertionGlloontoLitter(int liters)
    {
        return liters * 0.26417;
    }
    [HttpGet("ConvertMiles")]
    public Distance ConvertMiles(int miles)
    {
        return new Distance() { Miles = miles, Kilometers = miles * 1.609 };
    }
    [HttpPost("Convert")]
    public List<ConversionResponse> ConvertValues([FromBody] ConversionRequest request)
    {
        return new ConversionResponse().Conversions(request);
    }
}