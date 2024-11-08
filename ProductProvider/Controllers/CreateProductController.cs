﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductProvider.Interfaces;
using ProductProvider.Models;

namespace ProductProvider.Controllers
{
    [Route("api/createproduct")]
    [ApiController]
    public class CreateProductController(IProductService service) : ControllerBase
    {
        private readonly IProductService _service = service;
        [HttpPost]
        public async Task<ActionResult> CreateProduct(ProductModel model)
        {
            try
            {
                var result = await _service.CreateProductAsync(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}