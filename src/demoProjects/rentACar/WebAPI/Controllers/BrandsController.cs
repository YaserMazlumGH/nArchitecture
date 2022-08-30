﻿using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost("brand-add")]
        public async Task<IActionResult> BrandAdd([FromBody] CreateBrandCommand createBrandCommand )
        {
            CreatedBrandDto cbd = await Mediator.Send(createBrandCommand);
            return Created("", cbd);
        }
    }
}
