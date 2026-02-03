using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalservice;
        public RentalsController(IRentalService rentalservice)
        {
            _rentalservice = rentalservice;
        }
        [HttpGet("Getall")]
        public IActionResult GetAll()
        {
            var result = _rentalservice.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }
        [HttpGet("getrentalsdetaildtos")]
        public IActionResult GetRentalDetailDtos(int carId)
        {
            var result = _rentalservice.GetRentalDetailDtos(carId);
            if(result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }
        [HttpPost("Add")]
        public IActionResult Add(Rental rental)
        {
            var result=_rentalservice.Add(rental);
            if(result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Rental rental)
        {
            var result=_rentalservice.Delete(rental);
            if(result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }
        [HttpPut("Update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalservice.Update(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }

    }
}
