using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerservice;
        public CustomersController(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }
        [HttpGet("Getall")]
        public IActionResult Getall()
        {
            var result = _customerservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }
        [HttpGet("GetbyId")]
        public IActionResult GetbyId(int id)
        {
            var result=_customerservice.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Customer customer)
        {
            var result=_customerservice.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerservice.Delete(customer);
            if(result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }
        [HttpPut("Update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerservice.Update(customer);
            if(result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }
    }
}
