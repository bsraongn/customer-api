
using customerProject.Services.CustomerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace customerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {

            _customerService = customerService;


        }




        [HttpGet]

        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {

            return _customerService.GetCustomers();

        }

        [HttpGet("id")]

        public async Task<ActionResult<List<Customer>>> GetSingleCustomer(int id)  /*id ile arıyosun*/
        {

            var result = _customerService.GetSingleCustomer(id);

            if (result is null)
            {
                return NotFound("customer is not found");
            }
            return Ok(result);
        }


        [HttpPost]

        public async Task<ActionResult<List<Customer>>> AddCustomer(Customer customer)  /*tüm bilgileri giriyosun*/
        {

            var result = _customerService.AddCustomer(customer);
            return Ok(result);
        }

        [HttpPut("id")]

        public async Task<ActionResult<List<Customer>>> UpdateCustomer(int id, Customer request) /*id ve değiştirceğin şeyi giriyosun*/
        {

            var result = _customerService.UpdateCustomer(id, request);

            if (result is null)
            {
                return NotFound("customer is not found");
            }
            return Ok(result);

        }


        [HttpDelete("id")]

        public async Task<ActionResult<List<Customer>>> DeleteCustomer(int id)  /* id ile siliyosun*/
        {

          var result = _customerService.DeleteCustomer(id);
            
            if(result is null)
            {
                return NotFound("customer is not found");

            }
            return Ok(result);
        }

    }

}

