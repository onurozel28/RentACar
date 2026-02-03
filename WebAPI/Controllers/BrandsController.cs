using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandservice)
        {
            _brandService=brandservice;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result=_brandService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }
        [HttpGet("GetbyId")]
        public IActionResult GetById(int carId)
        {
            var result=_brandService.GetById(carId);
            if(result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }
        [HttpPost("Add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }
        [HttpPut("Update")]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
