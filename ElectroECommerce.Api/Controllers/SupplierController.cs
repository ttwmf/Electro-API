using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ElectroECommerce.Api.Controllers
{
    [ApiController]
    [Route("api/suppliers")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;
        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Supplier>> CreateSupplierAsync(CreateSupplierRequest supplier)
        {
            var result = await _supplierService.CreateSupplierAsync(supplier);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Supplier>> UpdateSupplierAsync(int id, UpdateSupplierRequest updateSupplierRequest)
        {
            var result = await _supplierService.UpdateSupplierAsync(id, updateSupplierRequest);
            return Ok(result);
        }

    }
}
