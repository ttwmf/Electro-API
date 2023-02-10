using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ElectroECommerce.Api.Controllers
{
    [ApiController]
    [Route("supplier")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;
        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpPost]
        [Route("suppliers")]
        public async Task<ActionResult<Supplier>> CreateAsync(Supplier supplier)
        {
            var result = await _supplierService.CreateSupplierAsync(supplier);
            return Ok(result);
        }

    }
}
